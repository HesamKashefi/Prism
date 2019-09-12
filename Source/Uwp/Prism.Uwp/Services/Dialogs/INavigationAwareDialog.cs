using System.Collections.Generic;

namespace Prism.Uwp.Services.Dialogs
{
    /// <summary>
    /// Adds support for extra data to be send to the dialog
    /// </summary>
    public interface INavigationAwareDialog
    {
        /// <summary>
        /// This method is called when dialog is opened
        /// </summary>
        /// <param name="parameters"></param>
        void OnNavigatedTo(Dictionary<string, object> parameters);
    }
}
