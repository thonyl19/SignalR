SignalR 相關應用測試
-------------------
#### 參考
[開始使用 ASP.NET Core SignalR](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-6.0&tabs=visual-studio-code)

#### Log
* 2022/10/10
專找適用於 vscode 的教學案例
```
//初始安裝程序
dotnet new webapp -o SignalRChat
code -r SignalRChat
//安裝 LibMan
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

//這個步驟必須等前面一個完成後再執行
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.js
```
啟動執行
```
	cd .\SignalRChat 
	dotnet watch run --project SignalRChat.csproj
```