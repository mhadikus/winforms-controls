<h1>Embed .NET Controls on the LabVIEW Front Panel</h1>

- See LabVIEW documentation [here](https://forums.ni.com/t5/Developer-Center-Resources/Embedding-Hosting-NET-UI-Controls-on-a-LabVIEW-Front-Panel/ta-p/3523293)
- The .NET container supports hosting WinForms controls.
- As of LabVIEW 2023, the .NET container does not support hosting WPF controls

<h2>Simple WinForms control with a text box and a checkbox</h2>

- Open [examples/SimpleWinFormControl.vi](https://github.com/mhadikus/winforms-controls/blob/main/examples/SimpleWinFormControl.vi) with LabVIEW 2020 or later
- The control has public properties and functions `IsChecked` and `GetTextBoxValue`

![image](SimpleWinFormControl-FP.jpg)

![image](SimpleWinFormControl-BD.jpg)

<h2>Chromium web browser</h2>

- The example user control [`WebView2Control`](https://github.com/mhadikus/winforms-controls/blob/main/WinFormsControls/WebView2Control.Designer.cs) contains the Microsoft Edge [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2) control
- The control has a public function [`Navigate(string url)`](https://github.com/mhadikus/winforms-controls/blob/main/WinFormsControls/WebView2Control.cs#L19)

![image](WebView2Control-FP.jpg)

![image](WebView2Control-BD.jpg)