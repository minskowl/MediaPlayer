using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Savchin.Wpf.Core;
using Savchin.Wpf.Input;

namespace MediaPlayer
{
    class MainWindowViewModel : ViewModelBase

    {
        public MediaElement MediaElement { get; set; }
        private Uri _sources;

        public Uri Source
        {
            get => _sources;
            set => Set(ref _sources, value);
        }

        public ICommand StopCommand { get; }
    public ICommand PauseCommand { get; }
        public MainWindowViewModel()
        {
            _sources = new Uri("f:\\0-02-05-0dd3e891d3ef0994ec1edbf361b04fa05d4ac2a71e2c3fa5ea356f4afa3d2b53_full.mp4");
            StopCommand=new DelegateCommand(OnStopCommand);
            PauseCommand=new DelegateCommand(OnPauseCommand);
        }

        private void OnPauseCommand()
        {
            MediaElement.Pause();
        }

        private void OnStopCommand()
        {
            MediaElement.Stop();
        }
    }
}
