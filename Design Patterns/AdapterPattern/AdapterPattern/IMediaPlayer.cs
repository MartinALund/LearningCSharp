using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IMediaPlayer
    {

        void Play(string AudioType, string Filename);
    }
}
