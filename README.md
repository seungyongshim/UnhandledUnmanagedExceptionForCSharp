# UnhandledUnmanagedExceptionForCSharp

## Visual Studio 2019 결과
- 처리되지 않는 예외 발생시 프로그램이 종료된다.
```cpp
#include "GenerateException.h"
#include <stdio.h>

void DivideZero()
{
    int a = 1 - 1;
    double b = 1 / a;
    printf("%f", b);
}

void AccessViolation()
{
    int* p = 0;
    *p = 1;
}
```
```csharp
[DllImport("UnhandledExceptionDll.Dll")]
extern public static void DivideZero();

[DllImport("UnhandledExceptionDll.Dll")]
extern public static void AccessViolation();

public static void Main(string[] args)
{
    try
    {
        AccessViolation();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
    
    try
    {
        DivideZero();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }

   
}
```

![이미지이름](./result1.png)


## HandleProcessCorruptedStateExceptions 특성 사용
- https://docs.microsoft.com/ko-kr/dotnet/api/system.runtime.exceptionservices.handleprocesscorruptedstateexceptionsattribute?view=netframework-4.8
- 프로세스가 손상된 상태이며 응용 프로그램의 실행을 유지하는 것은 좋지 않음
- AccessViolationException ave를 catch하여 응용 프로그램을 재실행 하도록 가이드 필요

```csharp

using System.Runtime.ExceptionServices;

[HandleProcessCorruptedStateExceptions]
public static void Main(string[] args)
{
   ...
}
```

