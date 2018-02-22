using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string Filename);
        void PlayMp4(string Filename);
    }
}
