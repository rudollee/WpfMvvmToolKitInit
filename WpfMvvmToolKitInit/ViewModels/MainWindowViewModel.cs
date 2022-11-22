using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfMvvmToolKitInit
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {
        public MainWindowViewModel() { }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IncreaseCommand))]
        private int count = 0;

        [RelayCommand(IncludeCancelCommand = true)]
        private async Task Increase(CancellationToken token)
        {
            try
            {
                await Task.Delay(1000, token);
                Count++;
            }
            catch (OperationCanceledException)
            {
                Count--;
            }
        }

    }
}
