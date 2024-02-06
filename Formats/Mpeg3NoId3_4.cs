namespace FileSignatures.Formats
{
    /// <summary>
    /// Mp3 with no Id4
    /// </summary>
    public class Mpeg3NoId3_4 : FileFormat
    {
        public Mpeg3NoId3_4() : base(new byte[] { 0xFF, 0xE3 }, "audio/mpeg", "mp3")
        {
        }
    }
}