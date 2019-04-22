// UnhandledExceptionDll.cpp : DLL을 위해 내보낸 함수를 정의합니다.
//

#include "pch.h"
#include "framework.h"
#include "UnhandledExceptionDll.h"


// 내보낸 변수의 예제입니다.
UNHANDLEDEXCEPTIONDLL_API int nUnhandledExceptionDll=0;

// 내보낸 함수의 예제입니다.
UNHANDLEDEXCEPTIONDLL_API int fnUnhandledExceptionDll(void)
{
    return 0;
}

// 내보낸 클래스의 생성자입니다.
CUnhandledExceptionDll::CUnhandledExceptionDll()
{
    return;
}
