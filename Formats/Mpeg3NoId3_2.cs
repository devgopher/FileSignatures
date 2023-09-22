namespace FileSignatures.Formats
{
    /// <summary>
    /// Mp3 with no Id3
    /// </summary>
    public class Mpeg3NoId3_2 : FileFormat
    {
        public Mpeg3NoId3_2() : base(new byte[] { 0xFF, 0xF3 }, "audio/mpeg", "mp3") { }
    }
}