using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace tarkov_settings.Setting
{
    class TarkovSetting
    {
        public Resolution Resolution { get; set; }
        public int ResolutionIndex { get; set; }
        public int AspectRatio { get; set; }
        public int GraphicsQuality { get; set; }
        public bool CustomGraphicsQuality { get; set; }
        public bool MultimonitorSupport { get; set; }
        public int VSync { get; set; }
        public int FullscreenMode { get; set; }
        public int LobbyFramerate { get; set; }
        public int GameFramerate { get; set; }
        public int TextureQuality { get; set; }
        public int ShadowsQuality { get; set; }
        public int ObjectLodQuality { get; set; }
        public int SuperSampling { get; set; }
        public int AnisotropicFiltering { get; set; }
        public int OverallVisibility { get; set; }
        public int ShadowVisibility { get; set; }
        public int Ssao { get; set; }
        public int Sharpen { get; set; }
        public int SSR { get; set; }
        public int AntiAliasing { get; set; }
        public int GrassShadow { get; set; }
        public int Bloom { get; set; }
        public int ChromaticAberrations { get; set; }
        public int Noise { get; set; }
        public int Hdr { get; set; }
        public int ZBlur { get; set; }
        public int HighQualityColor { get; set; }
    }
}
