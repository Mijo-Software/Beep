using System;
using System.Globalization;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Beep
{
	/// <summary>
	/// Main Window
	/// </summary>
	public partial class BeepForm : Form
	{
		private readonly CultureInfo culture = new CultureInfo(name: "en");

		/// <summary>
		/// Constructor
		/// </summary>
		public BeepForm() => InitializeComponent();

		/// <summary>
		/// Play a beep Sound
		/// </summary>
		/// <param name="frequency">frequency in Hertz</param>
		/// <param name="msDuration">duration in millseconds</param>
		/// <param name="volume">volume</param>
		public static void PlayBeep(ushort frequency = 2400, int msDuration = 100, ushort volume = 16383)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter writer = new BinaryWriter(output: memoryStream))
				{
					const double TAU = 2 * Math.PI;
					int formatChunkSize = 16;
					int headerSize = 8;
					short formatType = 1;
					short tracks = 1;
					int samplesPerSecond = 44100;
					short bitsPerSample = 16;
					short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
					int bytesPerSecond = samplesPerSecond * frameSize;
					int waveSize = 4;
					int samples = (int)((decimal)samplesPerSecond * msDuration / 1000);
					int dataChunkSize = samples * frameSize;
					int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
					// var encoding = new System.Text.UTF8Encoding();
					writer.Write(value: 0x46464952); // = encoding.GetBytes("RIFF")
					writer.Write(value: fileSize);
					writer.Write(value: 0x45564157); // = encoding.GetBytes("WAVE")
					writer.Write(value: 0x20746D66); // = encoding.GetBytes("fmt ")
					writer.Write(value: formatChunkSize);
					writer.Write(value: formatType);
					writer.Write(value: tracks);
					writer.Write(value: samplesPerSecond);
					writer.Write(value: bytesPerSecond);
					writer.Write(value: frameSize);
					writer.Write(value: bitsPerSample);
					writer.Write(value: 0x61746164); // = encoding.GetBytes("data")
					writer.Write(value: dataChunkSize);
					{
						double theta = frequency * TAU / samplesPerSecond;
						// 'volume' is UInt16 with range 0 thru Uint16.MaxValue ( = 65 535)
						// we need 'amp' to have the range of 0 thru Int16.MaxValue ( = 32 767)
						double amp = volume >> 2; // so we simply set amp = volume / 2
						for (int step = 0; step < samples; step++)
						{
							short s = (short)(amp * Math.Sin(a: theta * step));
							writer.Write(value: s);
						}
					}
					memoryStream.Seek(offset: 0, loc: SeekOrigin.Begin);
					using (SoundPlayer soundPlayer = new SoundPlayer(stream: memoryStream))
					{
						soundPlayer.Play();
					}
					writer.Close();
				}
				memoryStream.Close();
			}
		} // public static void PlayBeep(UInt16 frequency, int msDuration, UInt16 volume = 16383)

		/// <summary>
		/// Change the text of the button with some information who plays an beep sound
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ChangeBeepText_Scroll(object sender, EventArgs e) => buttonBeep.Text = "BEEP = " + ((ushort)trackBarFrequency.Value).ToString(provider: culture) + " hz / " + trackBarDuration.Value.ToString(provider: culture) + " ms / " + ((ushort)trackBarVolume.Value).ToString(provider: culture);

		/// <summary>
		/// Indicate to play a beep sound
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonBeep_Click(object sender, EventArgs e) => PlayBeep(frequency: (ushort)trackBarFrequency.Value, msDuration: trackBarDuration.Value, volume: (ushort)trackBarVolume.Value);

		/// <summary>
		/// Load the main window and indicate to play a beep sound
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void BeepForm_Load(object sender, EventArgs e) => PlayBeep(frequency: (ushort)trackBarFrequency.Value, msDuration: trackBarDuration.Value, volume: (ushort)trackBarVolume.Value);
	}
}
