# Microsoft.AspNetCore.ApiWidgets
This package contains some reusable, flexible and scalable api widgets for Asp.Net Core.

# Features
- [x] Request Filtering, use middleware to implement IIS Request Filtering moduler.
- [x] Plugin for Asp.Net Core to convert RESTful API to code + message/data structure.

## why?

In China, the GSM and TD-SCDMA will hijacking the HTTP status code 400, 404 to 139.com navigation page in some case. In this cases, we need to convert
RESTful API to

```C# 
public class ApiResult<T> {
	public ApiResult() {

	}

	public int Code { get; set; }

	public string Message { get; set; }

	public ApiResult(T data) {
		Data = data;
	}

	public T Data { get; set; }
}
```

- [ ] More...