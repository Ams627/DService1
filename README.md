# DService1
DialogService - sample implementation of dialogs for MVVM
To create a Window that can bring up a dialog we do this:
  1. Create a viewmodel FOR THE DIALOG
  2. Create a new ActualDialog<DialogWindow class>(dialogviewmodel)
  3. Create a viewmodel for the mainwindow - the viewmodel class takes an IDialogService as a constructor parameter: it can be passed anything that implements IDialogService
  4. Set the datacontext of the main window to the viewmodel for the mainwindow
