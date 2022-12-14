SignalR 相關應用測試
-------------------
#### 參考
[開始使用 ASP.NET Core SignalR](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-6.0&tabs=visual-studio-code)

### Todo
-------- 
* 2022/10/10 - 線上人數監控

	#### 參考

	- [SignalR 實現線上人數與廣播訊息](https://dotblogs.com.tw/acelee/2017/02/14/153503)

	啟動成功(http://localhost:5016/UserCount)

### Log
---------
* 2022/10/12 
	- 導入 Vue 程序
	- 改進 http://localhost:5016/CountUser/Main 和 Item 的呈現方式
   
* 2022/10/12 - 使用 Newtonsoft.Json
	#### 參考
	- [在 ASP.NET Core 和 SignalR 中使用 Newtonsoft.Json](https://towardsdev.com/using-newtonsoft-json-in-asp-net-core-and-signalr-55b0fa4645aa)
  
* 2022/10/11 - UserCount
	#### 參考
	- [Live-Product-Count-Using-Asp.Net-Core-6.0-with-SignalR](https://github.com/kalpeshsatasiya/Live-Product-Count-Using-Asp.Net-Core-6.0-with-SignalR)
* 2022/10/11
	- 取消使用 https
  
* 2022/10/10 - swagger 引入

	#### 參考
	- [Swashbuckle 與 ASP.NET Core 使用者入門](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio-code)

```
	dotnet add package Swashbuckle.AspNetCore -v 6.2.3
```
	
    	啟動成功,swagger 頁面(https://localhost:7165/swagger)

* 2022/10/10 - 監控測試

	#### 參考
	- [ASP.NET Core 中的記錄和診斷 SignalR](https://learn.microsoft.com/zh-tw/aspnet/core/signalr/diagnostics?view=aspnetcore-6.0)
	
	> 以前端的監測需求來說,沒什麼太大的用處

* 2022/10/10 - 專找適用於 vscode 的教學案例
```
//初始安裝程序
dotnet new webapp -o SignalRChat
code -r SignalRChat
//安裝 LibMan
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

//這個步驟必須等前面一個完成後再執行
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.js
```

```
	//啟動執程序
	cd .\SignalRChat 
	dotnet watch run --project SignalRChat.csproj
```