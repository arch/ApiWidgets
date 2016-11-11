# Microsoft.AspNetCore.ApiWidgets
This package contains some reusable, flexible and scalable api widgets for Asp.Net Core.

# Features
- [x] Request Filtering that use middleware to implement IIS Request Filtering module.
- [x] Plugin for Asp.Net Core to convert RESTful API to `200 OK` + `ApiResult` response.

> In China, the GSM and TD-SCDMA will hijacking the HTTP status code 400, 404 to 139.com navigation page in some case. In this cases, we need to convert
RESTful API to `200 OK` + `ApiResult`

```C# 
public class ApiResult<TResult> {
	public ApiResult() {

	}

	public int StatusCode { get; set; }

	public string Message { get; set; }

	public ApiResult(TResult result, int? statusCode) {
		StatusCode = statusCode ?? 200
		Result = result;
	}

	public TResult Result { get; set; }
}
```

- [ ] More...

# How to use

See [Host](src/Host) for more information.
