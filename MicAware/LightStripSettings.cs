namespace MicAware
{
    public class ColorInfo
    {
        public ColorInfo(string settingsString)
        {
            var colorParts = settingsString.Split(",");
            Hue = int.Parse(colorParts[0]);
            Saturation = int.Parse(colorParts[1]);
            Brightness = int.Parse(colorParts[2]);
        }

        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Brightness { get; set; }
    }
}