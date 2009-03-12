Imports Microsoft.VisualBasic
Imports System.Diagnostics
'Public Class GlobalMembersScraperParser
'    ' -----------------------------------------------------------------------------
'    ' MIN and MAX.  The Standard C++ template versions go by so many names (at
'    ' at least in the MS implementation) that you never know what's available 
'    ' -----------------------------------------------------------------------------
'	Public Shared Function SSMIN(Of Type)(ByVal arg1 As Type, ByVal arg2 As Type) As Type
'		Return If(arg2 < arg1, arg2, arg1)
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class Type>
'	Public Shared Function SSMAX(Of Type)(ByVal arg1 As Type, ByVal arg2 As Type) As Type
'		Return If(arg2 > arg1, arg2, arg1)
'	End Function

'	' If they have not #included W32Base.h (part of my W32 utility library) then
'	' we need to define some stuff.  Otherwise, this is all defined there.

'	#If (Not W32BASE_H) Then

'		' If they want us to use only standard C++ stuff (no Win32 stuff)

'		#If SS_ANSI Then

'			' On Win32 we have TCHAR.H so just include it.  This is NOT violating
'			' the spirit of SS_ANSI as we are not calling any Win32 functions here.

'			#If SS_WIN32 Then

'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
'	'			#include <WTYPES.H>
'				#If Not STRICT Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define STRICT
'					#Const STRICT = True
'				#End If

'			' ... but on non-Win32 platforms, we must #define the types we need.

'			#Else

'				#If UNICODE Then
'				#Else
'				#End If

'			#End If ' #ifndef _WIN32


'			' Make sure ASSERT and verify are defined using only ANSI stuff

'			#If Not ASSERT Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT(f) assert((f))
'				#Const ASSERT = True
'			#End If
'			#If Not VERIFY Then
'				#If _DEBUG Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define VERIFY(x) assert(((x)))
'					#Const VERIFY = True
'				#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define VERIFY(x) x
'					#Const VERIFY = True
'				#End If
'			#End If

'		#Else

'			#If Not STRICT Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define STRICT
'				#Const STRICT = True
'			#End If

'			' Make sure ASSERT and verify are defined

'			#If Not ASSERT Then
'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
'	'			#include <crtdbg.h>
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT(f) _ASSERTE((f))
'				#Const ASSERT = True
'			#End If
'			#If Not VERIFY Then
'				#If _DEBUG Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define VERIFY(x) ASSERT((x))
'					#Const VERIFY = True
'				#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define VERIFY(x) x
'					#Const VERIFY = True
'				#End If
'			#End If

'		#End If ' #ifdef SS_ANSI

'		#If Not UNUSED Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define UNUSED(x) x
'			#Const UNUSED = True
'		#End If

'	#End If ' #ifndef W32BASE_H

'	' Standard headers needed

'	#If Not SS_NO_LOCALE Then
'	#End If

'	' If this is a recent enough version of VC include comdef.h, so we can write
'	' member functions to deal with COM types & compiler support classes e.g.
'	' _bstr_t

'	#If _MSC_VER AndAlso (_MSC_VER >= 1100) Then
'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
'	' #include <comdef.h>
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_INC_COMDEF
'	 #Const SS_INC_COMDEF = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define STDSTRING_INC_COMDEF
'	 #Const STDSTRING_INC_COMDEF = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_NOTHROW __declspec(nothrow)
'	 #Const SS_NOTHROW = True
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_NOTHROW
'		#Const SS_NOTHROW = True
'	#End If

'	#If Not TRACE Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define TRACE_DEFINED_HERE
'		#Const TRACE_DEFINED_HERE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define TRACE
'		#Const TRACE = True
'	#End If

'	' Microsoft defines PCSTR, PCWSTR, etc, but no PCTSTR.  I hate to use the
'	' versions with the "L" in front of them because that's a leftover from Win 16
'	' days, even though it evaluates to the same thing.  Therefore, Define a PCSTR
'	' as an LPCTSTR.

'	#If (Not String) AndAlso (Not PCTSTR_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define PCTSTR_DEFINED
'		#Const PCTSTR_DEFINED = True
'	#End If

'	#If (Not PCOLESTR) AndAlso (Not PCOLESTR_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define PCOLESTR_DEFINED
'		#Const PCOLESTR_DEFINED = True
'	#End If

'	#If (Not POLESTR) AndAlso (Not POLESTR_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define POLESTR_DEFINED
'		#Const POLESTR_DEFINED = True
'	#End If

'	#If (Not PCUSTR) AndAlso (Not PCUSTR_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define PCUSTR_DEFINED
'		#Const PCUSTR_DEFINED = True
'	#End If


'	' SGI compiler 7.3 doesnt know these  types - oh and btw, remember to use
'	' -LANG:std in the CXX Flags
'	#If __sgi Then
'	#End If


'	' SS_USE_FACET macro and why we need it:
'	'
'	' Since I'm a good little Standard C++ programmer, I use locales.  Thus, I
'	' need to make use of the use_facet<> template function here.   Unfortunately,
'	' this need is complicated by the fact the MS' implementation of the Standard
'	' C++ Library has a non-standard version of use_facet that takes more
'	' arguments than the standard dictates.  Since I'm trying to write CStdString
'	' to work with any version of the Standard library, this presents a problem.
'	'
'	' The upshot of this is that I can't do 'use_facet' directly.  The MS' docs
'	' tell me that I have to use a macro, _USE() instead.  Since _USE obviously
'	' won't be available in other implementations, this means that I have to write
'	' my OWN macro -- SS_USE_FACET -- that evaluates either to _USE or to the
'	' standard, use_facet.
'	'
'	' If you are having trouble with the SS_USE_FACET macro, in your implementation
'	' of the Standard C++ Library, you can define your own version of SS_USE_FACET.

'	#If Not schMSG Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define schSTR(x) #x
'		#Const schSTR = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define schSTR2(x) "x"
'		#Const schSTR2 = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define schMSG(desc) message(__FILE__ "(" "x" "):" #desc)
'		#Const schMSG = True
'	#End If

'	#If Not SS_USE_FACET Then

'		' STLPort #defines a macro (__STL_NO_EXPLICIT_FUNCTION_TMPL_ARGS) for
'		' all MSVC builds, erroneously in my opinion.  It causes problems for
'		' my SS_ANSI builds.  In my code, I always comment out that line.  You'll
'		' find it in   \stlport\config\stl_msvc.h

'		#If __SGI_STL_PORT AndAlso (__SGI_STL_PORT >= &H400) Then

'			#If __STL_NO_EXPLICIT_FUNCTION_TMPL_ARGS AndAlso _MSC_VER Then
'				#If SS_ANSI Then
'	'C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
'	'				#pragma schMSG(__STL_NO_EXPLICIT_FUNCTION_TMPL_ARGS defined!!)
'				#End If
'			#End If
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_USE_FACET(loc, fac) std::use_facet<fac >(loc)
'			#Const SS_USE_FACET = True

'		#ElseIf _MSC_VER Then

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_USE_FACET(loc, fac) std::_USE(loc, fac)
'			#Const SS_USE_FACET = True

'		' ...and
'		#ElseIf _RWSTD_NO_TEMPLATE_ON_RETURN_TYPE Then

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_USE_FACET(loc, fac) std::use_facet(loc, (fac*)0)
'			#Const SS_USE_FACET = True

'		#Else

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_USE_FACET(loc, fac) std::use_facet<fac >(loc)
'			#Const SS_USE_FACET = True

'		#End If

'	#End If

'	' =============================================================================
'	' UNICODE/MBCS conversion macros.  Made to work just like the MFC/ATL ones.
'	' =============================================================================


'	' First define the conversion helper functions.  We define these regardless of
'	' any preprocessor macro settings since their names won't collide. 

'	' Not sure if we need all these headers.   I believe ANSI says we do.

'	#If Not va_start Then
'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
'	'	#include <varargs.h>
'	#End If


'	#If SS_NO_LOCALE Then

'		#If _WIN32 OrElse _WIN32_WCE Then

'			Public Shared Function StdCodeCvt(ByVal pDstW() As Char, ByVal nDst As Integer, ByVal pSrcA As String, ByVal nSrc As Integer, Optional ByVal acp As UInteger = CP_ACP) As Char
'				Debug.Assert(0 <> pSrcA)
'				Debug.Assert(0 <> pDstW)
'				pDstW(0) = ControlChars.NullChar
'				MultiByteToWideChar(acp, 0, pSrcA, nSrc, pDstW, nDst)
'				Return pDstW
'			End Function
'			Public Shared Function StdCodeCvt(ByRef pDstW As Char, ByVal nDst As Integer, ByVal pSrcA As String, ByVal nSrc As Integer, Optional ByVal acp As UInteger = CP_ACP) As Char
'				Return StdCodeCvt(pDstW, nDst, CStr(pSrcA), nSrc, acp)
'			End Function

'			Public Shared Function StdCodeCvt(ByVal pDstA() As SByte, ByVal nDst As Integer, ByVal pSrcW As Char, ByVal nSrc As Integer, Optional ByVal acp As UInteger = CP_ACP) As String
'				Debug.Assert(0 <> pDstA)
'				Debug.Assert(0 <> pSrcW)
'				pDstA(0) = ControlChars.NullChar
'				WideCharToMultiByte(acp, 0, pSrcW, nSrc, pDstA, nDst, 0, 0)
'				Return pDstA
'			End Function
'			Public Shared Function StdCodeCvt(ByRef pDstA As Byte, ByVal nDst As Integer, ByVal pSrcW As Char, ByVal nSrc As Integer, Optional ByVal acp As UInteger = CP_ACP) As Byte
'				Return CByte(StdCodeCvt(CSByte(pDstA), nDst, pSrcW, nSrc, acp))
'			End Function
'		#Else
'		#End If

'	#Else

'		' StdCodeCvt - made to look like Win32 functions WideCharToMultiByte
'		'				and MultiByteToWideChar but uses locales in SS_ANSI
'		'				builds.  There are a number of overloads.
'		'              First argument is the destination buffer.
'		'              Second argument is the source buffer
'		'#if defined (SS_ANSI) || !defined (SS_WIN32)

'		' 'SSCodeCvt' - shorthand name for the codecvt facet we use


'		Public Shared std.codecvt<* StdCodeCvt(ByVal pDstW() As std.codecvt, ByVal nDst As Integer, ByVal pSrcA As std.codecvt, ByVal nSrc As Integer, Optional ByVal loc As std.locale = std.locale())
'			Debug.Assert(0 <> pSrcA)
'			Debug.Assert(0 <> pDstW)

'			pDstW(0) = ControlChars.NullChar

'			If nSrc > 0 Then
'				const std.codecvt<* pNextSrcA = pSrcA
'				std.codecvt<* pNextDstW = pDstW
'				Dim res As std.codecvt(Of mbstate_t).result = std.codecvt(Of mbstate_t).ok
'				Const conv As std.codecvt(Of mbstate_t) = SS_USE_FACET(loc, std.codecvt(Of mbstate_t))
'				Dim st As New std.codecvt(Of mbstate_t).state_type()
'				res = conv.in(st, pSrcA, pSrcA + nSrc, pNextSrcA, pDstW, pDstW + nDst, pNextDstW)
'	#If _LINUX Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT2(a) if (Not(a)) {fprintf(stderr, "StdString: Assertion Failed on line %d" + Constants.vbLf, __LINE__);}
'	#Const ASSERT2 = True
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT2 ASSERT
'	#Const ASSERT2 = True
'	#End If
'				Debug.Assert(std.codecvt(Of mbstate_t).ok Is res)
'				Debug.Assert(std.codecvt(Of mbstate_t).error IsNot res)
'				Debug.Assert(pNextDstW >= pDstW)
'				Debug.Assert(pNextSrcA >= pSrcA)
'	'C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
'	'#undef ASSERT2
'				' Null terminate the converted string

'				If pNextDstW - pDstW > nDst Then
'					*(pDstW + nDst) = ControlChars.NullChar
'				Else
'					*pNextDstW = ControlChars.NullChar
'				End If
'			End If
'			Return pDstW
'		End Function
'		Public Shared std.codecvt<* StdCodeCvt(ByRef pDstW As std.codecvt, ByVal nDst As Integer, ByVal pSrcA As UInteger, ByVal nSrc As Integer, Optional ByVal loc As std.locale = std.locale())
'			Return StdCodeCvt(pDstW, nDst, (const std.codecvt<*)pSrcA, nSrc, loc)
'		End Function

'		Public Shared std.codecvt<* StdCodeCvt(ByVal pDstA() As std.codecvt, ByVal nDst As Integer, ByVal pSrcW As std.codecvt, ByVal nSrc As Integer, Optional ByVal loc As std.locale = std.locale())
'			Debug.Assert(0 <> pDstA)
'			Debug.Assert(0 <> pSrcW)

'			pDstA(0) = ControlChars.NullChar

'			If nSrc > 0 Then
'				std.codecvt<* pNextDstA = pDstA
'				const std.codecvt<* pNextSrcW = pSrcW
'				Dim res As std.codecvt(Of mbstate_t).result = std.codecvt(Of mbstate_t).ok
'				Const conv As std.codecvt(Of mbstate_t) = SS_USE_FACET(loc, std.codecvt(Of mbstate_t))
'				Dim st As New std.codecvt(Of mbstate_t).state_type()
'				res = conv.out(st, pSrcW, pSrcW + nSrc, pNextSrcW, pDstA, pDstA + nDst, pNextDstA)
'	#If _LINUX Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT2(a) if (Not(a)) {fprintf(stderr, "StdString: Assertion Failed on line %d" + Constants.vbLf, __LINE__);}
'	#Const ASSERT2 = True
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ASSERT2 ASSERT
'	#Const ASSERT2 = True
'	#End If
'				Debug.Assert(std.codecvt(Of mbstate_t).error IsNot res)
'				Debug.Assert(std.codecvt(Of mbstate_t).ok Is res) ' strict, comment out for sanity
'				Debug.Assert(pNextDstA >= pDstA)
'				Debug.Assert(pNextSrcW >= pSrcW)
'	'C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
'	'#undef ASSERT2

'				' Null terminate the converted string

'				If pNextDstA - pDstA > nDst Then
'					*(pDstA + nDst) = ControlChars.NullChar
'				Else
'					*pNextDstA = ControlChars.NullChar
'				End If
'			End If
'			Return pDstA
'		End Function

'		Public Shared UInteger std.codecvt<* StdCodeCvt(ByRef pDstA As UInteger, ByVal nDst As Integer, ByVal pSrcW As std.codecvt, ByVal nSrc As Integer, Optional ByVal loc As std.locale = std.locale())
'			Return (UInteger std.codecvt<*)StdCodeCvt((std.codecvt<*)pDstA, nDst, pSrcW, nSrc, loc)
'		End Function

'	#End If



'	' Unicode/MBCS conversion macros are only available on implementations of
'	' the "C" library that have the non-standard _alloca function.  As far as I
'	' know that's only Microsoft's though I've heard that the function exists
'	' elsewhere.  

'	#If SS_ALLOCA AndAlso (Not SS_NO_CONVERSION) Then


'		' Define our conversion macros to look exactly like Microsoft's to
'		' facilitate using this stuff both with and without MFC/ATL

'		#If _CONVERSION_USES_THREAD_LOCALE Then

'			#If Not _DEBUG Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSCVT int _cvt; _cvt; UINT _acp=GetACP(); _acp; PCWSTR _pw; _pw; PCSTR _pa; _pa
'				#Const SSCVT = True
'			#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSCVT int _cvt = 0; _cvt; UINT _acp=GetACP(); _acp; PCWSTR _pw=0; _pw; PCSTR _pa=0; _pa
'				#Const SSCVT = True
'			#End If
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2W(pa) ( ((_pa = pa) = 0) ? 0 : ( _cvt = (sslen(_pa)), StdCodeCvt((PWSTR) _alloca((_cvt+1)*2), (_cvt+1)*2, _pa, _cvt, _acp)))
'			#Const SSA2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2A(pw) ( ((_pw = pw) = 0) ? 0 : ( _cvt = sslen(_pw), StdCodeCvt((LPSTR) _alloca((_cvt+1)*2), (_cvt+1)*2, _pw, _cvt, _acp)))
'			#Const SSW2A = True
'		#Else

'			#If Not _DEBUG Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSCVT int _cvt; _cvt; UINT _acp=CP_ACP; _acp; PCWSTR _pw; _pw; PCSTR _pa; _pa
'				#Const SSCVT = True
'			#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSCVT int _cvt = 0; _cvt; UINT _acp=CP_ACP; _acp; PCWSTR _pw=0; _pw; PCSTR _pa=0; _pa
'				#Const SSCVT = True
'			#End If
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2W(pa) ( ((_pa = pa) = 0) ? 0 : ( _cvt = (sslen(_pa)), StdCodeCvt((PWSTR) _alloca((_cvt+1)*2), (_cvt+1)*2, _pa, _cvt)))
'			#Const SSA2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2A(pw) ( ((_pw = pw) = 0) ? 0 : ( _cvt = (sslen(_pw)), StdCodeCvt((LPSTR) _alloca((_cvt+1)*2), (_cvt+1)*2, _pw, _cvt)))
'			#Const SSW2A = True
'		#End If

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2CW(pa) ((PCWSTR)SSA2W((pa)))
'		#Const SSA2CW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2CA(pw) ((PCSTR)SSW2A((pw)))
'		#Const SSW2CA = True

'		#If UNICODE Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2A SSW2A
'			#Const SST2A = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2T SSA2W
'			#Const SSA2T = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2CA SSW2CA
'			#Const SST2CA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2CT SSA2CW
'			#Const SSA2CT = True
'			' (Did you get a compiler error here about not being able to convert
'			' PTSTR into PWSTR?  Then your _UNICODE and UNICODE flags are messed 
'			' up.  Best bet: #define BOTH macros before including any MS headers.)
'			Public Shared std.codecvt<* SST2W(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSW2T(ByRef p As std.codecvt) As String
'				Return p
'			End Function
'			Public Shared std.codecvt<* SST2CW(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSW2CT(ByVal p As std.codecvt) As String
'				Return p
'			End Function
'		#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2W SSA2W
'			#Const SST2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2T SSW2A
'			#Const SSW2T = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2CW SSA2CW
'			#Const SST2CW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2CT SSW2CA
'			#Const SSW2CT = True
'			Public Shared std.codecvt<* SST2A(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSA2T(ByRef p As std.codecvt) As String
'				Return p
'			End Function
'			Public Shared std.codecvt<* SST2CA(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSA2CT(ByVal p As std.codecvt) As String
'				Return p
'			End Function
'		#End If ' #ifdef UNICODE

'		#If UNICODE Then
'		' in these cases the default (TCHAR) is the same as OLECHAR
'			Public Shared std.codecvt<* SST2COLE(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSOLE2CT(ByVal p As std.codecvt) As String
'				Return p
'			End Function
'			Public Shared std.codecvt<* SST2OLE(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSOLE2T(ByRef p As std.codecvt) As String
'				Return p
'			End Function
'		#ElseIf OLE2ANSI Then
'		' in these cases the default (TCHAR) is the same as OLECHAR
'			Public Shared std.codecvt<* SST2COLE(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSOLE2CT(ByVal p As std.codecvt) As String
'				Return p
'			End Function
'			Public Shared std.codecvt<* SST2OLE(ByVal p As String)
'				Return p
'			End Function
'			Public Shared Function SSOLE2T(ByRef p As std.codecvt) As String
'				Return p
'			End Function
'		#Else
'			'CharNextW doesn't work on Win95 so we use this
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2COLE(pa) ((PCWSTR)SSA2W(((pa))))
'			#Const SST2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SST2OLE(pa) SSA2W((pa))
'			#Const SST2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2CT(po) ((PCSTR)SSW2A(((po))))
'			#Const SSOLE2CT = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2T(po) SSW2A((po))
'			#Const SSOLE2T = True
'		#End If

'		#If OLE2ANSI Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2OLE SSW2A
'			#Const SSW2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2W SSA2W
'			#Const SSOLE2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSW2COLE SSW2CA
'			#Const SSW2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2CW SSA2CW
'			#Const SSOLE2CW = True
'			Public Shared std.codecvt<* SSA2OLE(ByRef p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSOLE2A(ByRef p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSA2COLE(ByVal p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSOLE2CA(ByVal p As std.codecvt)
'				Return p
'			End Function
'		#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2OLE SSA2W
'			#Const SSA2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2A SSW2A
'			#Const SSOLE2A = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSA2COLE SSA2CW
'			#Const SSA2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSOLE2CA SSW2CA
'			#Const SSOLE2CA = True
'			Public Shared std.codecvt<* SSW2OLE(ByRef p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSOLE2W(ByRef p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSW2COLE(ByVal p As std.codecvt)
'				Return p
'			End Function
'			Public Shared std.codecvt<* SSOLE2CW(ByVal p As std.codecvt)
'				Return p
'			End Function
'		#End If

'		' Above we've defined macros that look like MS' but all have
'		' an 'SS' prefix.  Now we need the real macros.  We'll either
'		' get them from the macros above or from MFC/ATL. 

'		#If USES_CONVERSION Then

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define _NO_STDCONVERSION
'			#Const _NO_STDCONVERSION = True

'		#Else

'			#If _MFC_VER Then

'	'C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
'	'			#include <afxconv.h>
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define _NO_STDCONVERSION
'				#Const _NO_STDCONVERSION = True

'			#Else

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define USES_CONVERSION SSCVT
'				#Const USES_CONVERSION = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define A2CW SSA2CW
'				#Const A2CW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define W2CA SSW2CA
'				#Const W2CA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2A SST2A
'				#Const T2A = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define A2T SSA2T
'				#Const A2T = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2W SST2W
'				#Const T2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define W2T SSW2T
'				#Const W2T = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2CA SST2CA
'				#Const T2CA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define A2CT SSA2CT
'				#Const A2CT = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2CW SST2CW
'				#Const T2CW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define W2CT SSW2CT
'				#Const W2CT = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ocslen sslen
'				#Const ocslen = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define ocscpy sscpy
'				#Const ocscpy = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2COLE SST2COLE
'				#Const T2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2CT SSOLE2CT
'				#Const OLE2CT = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define T2OLE SST2COLE
'				#Const T2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2T SSOLE2CT
'				#Const OLE2T = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define A2OLE SSA2OLE
'				#Const A2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2A SSOLE2A
'				#Const OLE2A = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define W2OLE SSW2OLE
'				#Const W2OLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2W SSOLE2W
'				#Const OLE2W = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define A2COLE SSA2COLE
'				#Const A2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2CA SSOLE2CA
'				#Const OLE2CA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define W2COLE SSW2COLE
'				#Const W2COLE = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OLE2CW SSOLE2CW
'				#Const OLE2CW = True

'			#End If ' #ifdef _MFC_VER
'		#End If ' #ifndef USES_CONVERSION
'	#End If ' #ifndef SS_NO_CONVERSION

'	' Define ostring - generic name for std::basic_string<OLECHAR>

'	#If (Not ostring) AndAlso (Not OSTRING_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define OSTRING_DEFINED
'		#Const OSTRING_DEFINED = True
'	#End If

'	' StdCodeCvt when there's no conversion to be done
'	Public Shared std.codecvt<* StdCodeCvt(ByVal pDst() As std.codecvt, ByVal nDst As Integer, ByVal pSrc As std.codecvt, ByVal nSrc As Integer)
'		Dim nChars As Integer = SSMIN(nSrc, nDst)

'		If nChars > 0 Then
'			pDst(0) = ControlChars.NullChar
'			std.basic_string<std.codecvt(Of ).traits_type.copy(pDst, pSrc, nChars)
'	'		std::char_traits<char>::copy(pDst, pSrc, nChars);
'			pDst(nChars) = ControlChars.NullChar
'		End If

'		Return pDst
'	End Function
'	Public Shared std.codecvt<* StdCodeCvt(ByRef pDst As std.codecvt, ByVal nDst As Integer, ByVal pSrc As UInteger, ByVal nSrc As Integer)
'		Return StdCodeCvt(pDst, nDst, (const std.codecvt<*)pSrc, nSrc)
'	End Function
'	Public Shared UInteger std.codecvt<* StdCodeCvt(ByRef pDst As UInteger, ByVal nDst As Integer, ByVal pSrc As std.codecvt, ByVal nSrc As Integer)
'		Return (UInteger std.codecvt<*)StdCodeCvt((std.codecvt<*)pDst, nDst, pSrc, nSrc)
'	End Function

'	Public Shared std.codecvt<* StdCodeCvt(ByVal pDst() As std.codecvt, ByVal nDst As Integer, ByVal pSrc As std.codecvt, ByVal nSrc As Integer)
'		Dim nChars As Integer = SSMIN(nSrc, nDst)

'		If nChars > 0 Then
'			pDst(0) = ControlChars.NullChar
'			std.basic_string<std.codecvt(Of ).traits_type.copy(pDst, pSrc, nChars)
'	'		std::char_traits<wchar_t>::copy(pDst, pSrc, nChars);
'			pDst(nChars) = ControlChars.NullChar
'		End If

'		Return pDst
'	End Function


'	' Define tstring -- generic name for std::basic_string<TCHAR>

'	#If (Not tstring) AndAlso (Not TSTRING_DEFINED) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define TSTRING_DEFINED
'		#Const TSTRING_DEFINED = True
'	#End If

'	' a very shorthand way of applying the fix for KB problem Q172398
'	' (basic_string assignment bug)

'	#If _MSC_VER AndAlso (_MSC_VER < 1200) Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define Q172398(x) (x).erase()
'		#Const Q172398 = True
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define Q172398(x)
'		#Const Q172398 = True
'	#End If

'	' =============================================================================
'	' INLINE FUNCTIONS ON WHICH CSTDSTRING RELIES
'	'
'	' Usually for generic text mapping, we rely on preprocessor macro definitions
'	' to map to string functions.  However the CStdStr<> template cannot use
'	' macro-based generic text mappings because its character types do not get
'	' resolved until template processing which comes AFTER macro processing.  In
'	' other words, the preprocessor macro UNICODE is of little help to us in the
'	' CStdStr template
'	'
'	' Therefore, to keep the CStdStr declaration simple, we have these inline
'	' functions.  The template calls them often.  Since they are inline (and NOT
'	' exported when this is built as a DLL), they will probably be resolved away
'	' to nothing. 
'	'
'	' Without these functions, the CStdStr<> template would probably have to broken
'	' out into two, almost identical classes.  Either that or it would be a huge,
'	' convoluted mess, with tons of "if" statements all over the place checking the
'	' size of template parameter CT.
'	' =============================================================================

'	#If SS_NO_LOCALE Then

'		' --------------------------------------------------------------------------
'		' Win32 GetStringTypeEx wrappers
'		' --------------------------------------------------------------------------
'		Public Shared Function wsGetStringType(ByVal lc As UInteger, ByVal dwT As UInteger, ByVal pS As std.codecvt, ByVal nSize As Integer, ByRef pWd As UShort) As Boolean
'			Return 0 <> GetStringTypeExA(lc, dwT, pS, nSize, pWd)
'		End Function
'		Public Shared Function wsGetStringType(ByVal lc As UInteger, ByVal dwT As UInteger, ByVal pS As std.codecvt, ByVal nSize As Integer, ByRef pWd As UShort) As Boolean
'			Return 0 <> GetStringTypeExW(lc, dwT, pS, nSize, pWd)
'		End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>


'			Public Shared Function ssisspace(Of CT)(ByVal t As CT) As Boolean
'			Dim toYourMother As UShort
'			Return wsGetStringType(GetThreadLocale(), CT_CTYPE1, t, 1, toYourMother) AndAlso 0 <> (C1_BLANK And toYourMother)
'			End Function

'	#End If

'	' If they defined SS_NO_REFCOUNT, then we must convert all assignments

'	#If _MSC_VER AndAlso (_MSC_VER < 1300) Then
'		#If SS_NO_REFCOUNT Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSREF(x) (x).c_str()
'			#Const SSREF = True
'		#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSREF(x) (x)
'			#Const SSREF = True
'		#End If
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SSREF(x) (x)
'		#Const SSREF = True
'	#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'	' -----------------------------------------------------------------------------
'	' sslen: strlen/wcslen wrappers
'	' -----------------------------------------------------------------------------
'	Public Shared Function sslen(Of CT)(ByVal pT As CT) As Integer
'		Return If(0 = pT, 0, CInt(Fix(std.basic_string(Of CT).traits_type.length(pT))))
'	'	return 0 == pT ? 0 : std::char_traits<CT>::length(pT);
'	End Function
'	Public Shared SS_NOTHROW Function sslen(ByVal s As String) As Integer
'		Return CInt(Fix(s.Length))
'	End Function
'	Public Shared SS_NOTHROW Function sslen(ByVal s As String) As Integer
'		Return CInt(Fix(s.Length))
'	End Function

'	' -----------------------------------------------------------------------------
'	' sstolower/sstoupper -- convert characters to upper/lower case
'	' -----------------------------------------------------------------------------

'	#If SS_NO_LOCALE Then
'		Public Shared std.codecvt< sstoupper(ByVal ch As std.codecvt)
'			Return (std.codecvt<).toupper(ch)
'		End Function
'		Public Shared std.codecvt< sstoupper(ByVal ch As std.codecvt)
'			Return (std.codecvt<).towupper(ch)
'		End Function
'		Public Shared std.codecvt< sstolower(ByVal ch As std.codecvt)
'			Return (std.codecvt<).tolower(ch)
'		End Function
'		Public Shared std.codecvt< sstolower(ByVal ch As std.codecvt)
'			Return (std.codecvt<).tolower(ch)
'		End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'	#Else
'		Public Shared Function sstolower(Of CT)(ByVal t As CT, Optional ByVal loc As std.locale = std.locale()) As CT
'			Return std.tolower(Of CT)(t, loc)
'		End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'		Public Shared Function sstoupper(Of CT)(ByVal t As CT, Optional ByVal loc As std.locale = std.locale()) As CT
'			Return std.toupper(Of CT)(t, loc)
'		End Function
'	#End If

'	' -----------------------------------------------------------------------------
'	' ssasn: assignment functions -- assign "sSrc" to "sDst"
'	' -----------------------------------------------------------------------------

'	Public Shared Sub ssasn(ByRef sDst As String, ByVal sSrc As String)
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		If sDst.c_str() <> sSrc.c_str() Then
'			sDst.erase()
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'			sDst.assign((sSrc))
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal pA As std.codecvt)
'		' Watch out for NULLs, as always.

'		If 0 = pA Then
'			sDst.erase()

'		' If pA actually points to part of sDst, we must NOT erase(), but
'		' rather take a substring

''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		ElseIf pA >= sDst.c_str() AndAlso pA <= sDst.c_str() + sDst.Length Then
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			sDst =sDst.Substring(CType(pA-sDst.c_str(), String.size_type))

'		' Otherwise (most cases) apply the assignment bug fix, if applicable
'		' and do the assignment

'		Else
'			x(sDst)
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'			sDst.assign(pA)
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal sSrc As String)
'		If String.IsNullOrEmpty(sSrc) Then
'			sDst.erase()
'		Else
'			Dim nDst As Integer = CInt(Fix(sSrc.Length))

'			' In MBCS builds, pad the buffer to account for the possibility of
'			' some 3 byte characters.  Not perfect but should get most cases.

'	#If SS_MBCS Then
'			' In MBCS builds, we don't know how long the destination string will be.
'			nDst = CInt(Fix(CDbl(nDst) * 1.3))
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, sSrc.c_str(), CInt(Fix(sSrc.Length)))
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, sSrc.c_str(), CInt(Fix(sSrc.Length)))
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(sSrc.Length)
'	#End If
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal pW As std.codecvt)
'		Dim nSrc As Integer = sslen(pW)
'		If nSrc > 0 Then
'			Dim nSrc As Integer = sslen(pW)
'			Dim nDst As Integer = nSrc

'			' In MBCS builds, pad the buffer to account for the possibility of
'			' some 3 byte characters.  Not perfect but should get most cases.

'	#If SS_MBCS Then
'			nDst = CInt(Fix(CDbl(nDst) * 1.3))
'			' In MBCS builds, we don't know how long the destination string will be.
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + 1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, pW, nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + 1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, pW, nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst)
'	#End If
'		Else
'			sDst.erase()
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal nNull As Integer)
'	  'UNUSED(nNull);
'		Debug.Assert(nNull =0)
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'		sDst.assign("")
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal sSrc As String)
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		If sDst.c_str() <> sSrc.c_str() Then
'			sDst.erase()
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'			sDst.assign((sSrc))
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal pW As std.codecvt)
'		' Watch out for NULLs, as always.

'		If 0 = pW Then
'			sDst.erase()

'		' If pW actually points to part of sDst, we must NOT erase(), but
'		' rather take a substring

''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		ElseIf pW >= sDst.c_str() AndAlso pW <= sDst.c_str() + sDst.Length Then
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			sDst = sDst.Substring(CType(pW-sDst.c_str(), String.size_type))

'		' Otherwise (most cases) apply the assignment bug fix, if applicable
'		' and do the assignment

'		Else
'			x(sDst)
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'			sDst.assign(pW)
'		End If
'	End Sub
'	'C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
'	'#undef StrSizeType
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal sSrc As String)
'		If String.IsNullOrEmpty(sSrc) Then
'			sDst.erase()
'		Else
'			Dim nSrc As Integer = CInt(Fix(sSrc.Length))
'			Dim nDst As Integer = nSrc

''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nSrc+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, sSrc.c_str(), nSrc)

''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(sslen(szCvt))
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal pA As std.codecvt)
'		Dim nSrc As Integer = sslen(pA)

'		If 0 = nSrc Then
'			sDst.erase()
'		Else
'			Dim nDst As Integer = nSrc
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()), nDst, pA, nSrc)

''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(sslen(szCvt))
'		End If
'	End Sub
'	Public Shared Sub ssasn(ByRef sDst As String, ByVal nNull As Integer)
'	  'UNUSED(nNull);
'		Debug.Assert(nNull =0)
''C++ TO VB CONVERTER TODO TASK: The assign method is not converted to VB:
'		sDst.assign("")
'	End Sub


'	' -----------------------------------------------------------------------------
'	' ssadd: string object concatenation -- add second argument to first
'	' -----------------------------------------------------------------------------
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal sSrc As String)
'		Dim nSrc As Integer = CInt(Fix(sSrc.Length))

'		If nSrc > 0 Then
'			Dim nDst As Integer = CInt(Fix(sDst.Length))
'			Dim nAdd As Integer = nSrc

'			' In MBCS builds, pad the buffer to account for the possibility of
'			' some 3 byte characters.  Not perfect but should get most cases.

'	#If SS_MBCS Then
'			nAdd = CInt(Fix(CDbl(nAdd) * 1.3))
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst+nAdd+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nAdd, sSrc.c_str(), nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst+nAdd+1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nAdd, sSrc.c_str(), nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nAdd)
'	#End If
'		End If
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal sSrc As String)
'		sDst &= sSrc
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal pW As std.codecvt)
'		Dim nSrc As Integer = sslen(pW)
'		If nSrc > 0 Then
'			Dim nDst As Integer = CInt(Fix(sDst.Length))
'			Dim nAdd As Integer = nSrc

'	#If SS_MBCS Then
'			nAdd = CInt(Fix(CDbl(nAdd) * 1.3))
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nAdd + 1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nAdd, pW, nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nAdd + 1)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nAdd, pW, nSrc)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nSrc)
'	#End If
'		End If
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal pA As std.codecvt)
'		If pA IsNot Nothing Then
'			' If the string being added is our internal string or a part of our
'			' internal string, then we must NOT do any reallocation without
'			' first copying that string to another object (since we're using a
'			' direct pointer)

''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			If pA >= sDst.c_str() AndAlso pA <= sDst.c_str()+ sDst.Length Then
''C++ TO VB CONVERTER TODO TASK: The capacity method is not converted to VB:
'				If sDst.capacity() <= sDst.Length+sslen(pA) Then
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'					sDst.append(CStr(pA))
'				Else
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'					sDst.append(pA)
'				End If
'			Else
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'				sDst.append(pA)
'			End If
'		End If
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal sSrc As String)
'		sDst &= sSrc
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal sSrc As String)
'		If (Not String.IsNullOrEmpty(sSrc)) Then
'			Dim nSrc As Integer = CInt(Fix(sSrc.Length))
'			Dim nDst As Integer = CInt(Fix(sDst.Length))

''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nSrc + 1)
'	#If SS_MBCS Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nSrc, sSrc.c_str(), nSrc+1)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nSrc, sSrc.c_str(), nSrc+1)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nSrc)
'	#End If
'		End If
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal pA As std.codecvt)
'		Dim nSrc As Integer = sslen(pA)

'		If nSrc > 0 Then
'			Dim nDst As Integer = CInt(Fix(sDst.Length))

''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nSrc + 1)
'	#If SS_MBCS Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			const std.codecvt<* szCvt = StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nSrc, pA, nSrc+1)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + sslen(szCvt))
'	#Else
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: The data method is not converted to VB:
'			StdCodeCvt(const_cast<String.pointer>(sDst.data()+nDst), nSrc, pA, nSrc+1)
''C++ TO VB CONVERTER TODO TASK: The resize method is not converted to VB:
'			sDst.resize(nDst + nSrc)
'	#End If
'		End If
'	End Sub
'	Public Shared Sub ssadd(ByRef sDst As String, ByVal pW As std.codecvt)
'		If pW IsNot Nothing Then
'			' If the string being added is our internal string or a part of our
'			' internal string, then we must NOT do any reallocation without
'			' first copying that string to another object (since we're using a
'			' direct pointer)

''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			If pW >= sDst.c_str() AndAlso pW <= sDst.c_str()+ sDst.Length Then
''C++ TO VB CONVERTER TODO TASK: The capacity method is not converted to VB:
'				If sDst.capacity() <= sDst.Length+sslen(pW) Then
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'					sDst.append(CStr(pW))
'				Else
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'					sDst.append(pW)
'				End If
'			Else
''C++ TO VB CONVERTER TODO TASK: The append method is not converted to VB:
'				sDst.append(pW)
'			End If
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>


'	' -----------------------------------------------------------------------------
'	' sscmp: comparison (case sensitive, not affected by locale)
'	' -----------------------------------------------------------------------------
'	Public Shared Function sscmp(Of CT)(ByVal pA1 As CT, ByVal pA2 As CT) As Integer
'		Dim f As CT
'		Dim l As CT

'		Do
'			f = *(pA1)
'			pA1 += 1
'			l = *(pA2)
'			pA2 += 1
'		Loop While (f) AndAlso (f Is l)

'		Return CInt(Fix(f - l))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'	' -----------------------------------------------------------------------------
'	' ssicmp: comparison (case INsensitive, not affected by locale)
'	' -----------------------------------------------------------------------------
'	Public Shared Function ssicmp(Of CT)(ByVal pA1 As CT, ByVal pA2 As CT) As Integer
'		' Using the "C" locale = "not affected by locale"

'		Dim loc As std.locale = std.locale.classic()
'		Const ct As std.ctype(Of CT) = SS_USE_FACET(loc, std.ctype(Of CT))
'		Dim f As CT
'		Dim l As CT

'		Do
'			f = ct.tolower(*(pA1))
'			pA1 += 1
'			l = ct.tolower(*(pA2))
'			pA2 += 1
'		Loop While (f) AndAlso (f Is l)

'		Return CInt(Fix(f - l))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'	' -----------------------------------------------------------------------------
'	' ssupr/sslwr: Uppercase/Lowercase conversion functions
'	' -----------------------------------------------------------------------------

'	Public Shared Sub sslwr(Of CT)(ByRef pT As CT, ByVal nLen As size_t, Optional ByVal loc As std.locale = std.locale())
'		SS_USE_FACET(loc, std.ctype(Of CT)).tolower(pT, pT+nLen)
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'	Public Shared Sub ssupr(Of CT)(ByRef pT As CT, ByVal nLen As size_t, Optional ByVal loc As std.locale = std.locale())
'		SS_USE_FACET(loc, std.ctype(Of CT)).toupper(pT, pT+nLen)
'	End Sub

'	' -----------------------------------------------------------------------------
'	' vsprintf/vswprintf or _vsnprintf/_vsnwprintf equivalents.  In standard
'	' builds we can't use _vsnprintf/_vsnwsprintf because they're MS extensions.
'	'
'	' -----------------------------------------------------------------------------
'	' Borland's headers put some ANSI "C" functions in the 'std' namespace. 
'	' Promote them to the global namespace so we can use them here.

'	#If __BORLANDC__ Then
'	#End If

'		' GNU is supposed to have vsnprintf and vsnwprintf.  But only the newer
'		' distributions do.

'	#If __GNUC__ Then

'		Public Shared Function ssvsprintf(ByRef pA As std.codecvt, ByVal nCount As size_t, ByVal pFmtA As std.codecvt, ByVal vl As va_list) As Integer
'			Return vsnprintf(pA, nCount, pFmtA, vl)
'		End Function
'		Public Shared Function ssvsprintf(ByRef pW As std.codecvt, ByVal nCount As size_t, ByVal pFmtW As std.codecvt, ByVal vl As va_list) As Integer
'			Return vswprintf(pW, nCount, pFmtW, vl)
'		End Function

'		' Microsofties can use
'	#ElseIf _MSC_VER AndAlso (Not SS_ANSI) Then

'		Public Shared Function ssvsprintf(ByRef pA As std.codecvt, ByVal nCount As size_t, ByVal pFmtA As std.codecvt, ByVal vl As va_list) As Integer
'			Return _vsnprintf(pA, nCount, pFmtA, vl)
'		End Function
'		Public Shared Function ssvsprintf(ByRef pW As std.codecvt, ByVal nCount As size_t, ByVal pFmtW As std.codecvt, ByVal vl As va_list) As Integer
'			Return _vsnwprintf(pW, nCount, pFmtW, vl)
'		End Function

'	#ElseIf SS_DANGEROUS_FORMAT Then

'	'C++ TO VB CONVERTER NOTE: Embedded comments are not maintained by C++ to VB Converter
'	'ORIGINAL LINE: inline int ssvsprintf(PSTR pA, size_t /*nCount*/, PCSTR pFmtA, va_list vl)
'		Public Shared Function ssvsprintf(ByRef pA As std.codecvt, ByVal UnnamedParameter1 As size_t, ByVal pFmtA As std.codecvt, ByVal vl As va_list) As Integer
'			Return vsprintf(pA, pFmtA, vl)
'		End Function

'		Public Shared Function ssvsprintf(ByRef pW As std.codecvt, ByVal nCount As size_t, ByVal pFmtW As std.codecvt, ByVal vl As va_list) As Integer
'			' JMO: Some distributions of the "C" have a version of vswprintf that
'			' takes 3 arguments (e.g. Microsoft, Borland, GNU).  Others have a 
'			' version which takes 4 arguments (an extra "count" argument in the
'			' second position.  The best stab I can take at this so far is that if
'			' you are NOT running with MS, Borland, or GNU, then I'll assume you
'			' have the version that takes 4 arguments.
'			'
'			' I'm sure that these checks don't catch every platform correctly so if
'			' you get compiler errors on one of the lines immediately below, it's
'			' probably because your implemntation takes a different number of
'			' arguments.  You can comment out the offending line (and use the
'			' alternate version) or you can figure out what compiler flag to check
'			' and add that preprocessor check in.  Regardless, if you get an error
'			' on these lines, I'd sure like to hear from you about it.
'			'
'			' Thanks to Ronny Schulz for the SGI-specific checks here.

'	'	#if !defined(__MWERKS__) && !defined(__SUNPRO_CC_COMPAT) && !defined(__SUNPRO_CC)

'		#If (Not _MSC_VER) AndAlso (Not __BORLANDC__) AndAlso (Not __GNUC__) AndAlso (Not __sgi) Then
'			Return vswprintf(pW, nCount, pFmtW, vl)

'		' suddenly with the current SGI 7.3 compiler there is no such function as
'		' vswprintf and the substitute needs explicit casts to compile


'		#ElseIf __sgi Then
'			nCount
'			Return vsprintf((std.codecvt< *)pW, (std.codecvt< *)pFmtW, vl)


'		#Else
'			nCount
'			Return vswprintf(pW, pFmtW, vl)

'		#End If

'		End Function

'	#End If

'		' GOT COMPILER PROBLEMS HERE?
'		' ---------------------------
'		' Does your compiler choke on one or more of the following 2 functions?  It
'		' probably means that you don't have have either vsnprintf or vsnwprintf in
'		' your version of the CRT.  This is understandable since neither is an ANSI
'		' "C" function.  However it still leaves you in a dilemma.  In order to make
'		' this code build, you're going to have to to use some non-length-checked
'		' formatting functions that every CRT has:  vsprintf and vswprintf.  
'		'
'		' This is very dangerous.  With the proper erroneous (or malicious) code, it
'		' can lead to buffer overlows and crashing your PC.  Use at your own risk
'		' In order to use them, just #define SS_DANGEROUS_FORMAT at the top of
'		' this file.
'		'
'		' Even THEN you might not be all the way home due to some non-conforming
'		' distributions.  More on this in the comments below.

'		Public Shared Function ssnprintf(ByRef pA As std.codecvt, ByVal nCount As size_t, ByVal pFmtA As std.codecvt, ByVal vl As va_list) As Integer
'		#If _MSC_VER Then
'				Return _vsnprintf(pA, nCount, pFmtA, vl)
'		#Else
'				Return vsnprintf(pA, nCount, pFmtA, vl)
'		#End If
'		End Function
'		Public Shared Function ssnprintf(ByRef pW As std.codecvt, ByVal nCount As size_t, ByVal pFmtW As std.codecvt, ByVal vl As va_list) As Integer
'		#If _MSC_VER Then
'				Return _vsnwprintf(pW, nCount, pFmtW, vl)
'		#Else
'				Return vswprintf(pW, nCount, pFmtW, vl)
'		#End If
'		End Function




'	' -----------------------------------------------------------------------------
'	' ssload: Type safe, overloaded ::LoadString wrappers
'	' There is no equivalent of these in non-Win32-specific builds.  However, I'm
'	' thinking that with the message facet, there might eventually be one
'	' -----------------------------------------------------------------------------
'	#If SS_WIN32 AndAlso (Not SS_ANSI) Then
'		Public Shared Function ssload(ByVal hInst As IntPtr, ByVal uId As UInteger, ByRef pBuf As std.codecvt, ByVal nMax As Integer) As Integer
'			Return LoadStringA(hInst, uId, pBuf, nMax)
'		End Function
'		Public Shared Function ssload(ByVal hInst As IntPtr, ByVal uId As UInteger, ByRef pBuf As std.codecvt, ByVal nMax As Integer) As Integer
'			Return LoadStringW(hInst, uId, pBuf, nMax)
'		End Function
'	#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template <typename CT>


'	' -----------------------------------------------------------------------------
'	' sscoll/ssicoll: Collation wrappers
'	'		Note -- with MSVC I have reversed the arguments order here because the
'	'		functions appear to return the opposite of what they should
'	' -----------------------------------------------------------------------------
'	#If Not SS_NO_LOCALE Then
'	Public Shared Function sscoll(Of CT)(ByVal sz1 As CT, ByVal nLen1 As Integer, ByVal sz2 As CT, ByVal nLen2 As Integer) As Integer
'		Const coll As std.collate(Of CT) = SS_USE_FACET(std.locale(), std.collate(Of CT))

'		Return coll.compare(sz2, sz2+nLen2, sz1, sz1+nLen1)
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template <typename CT>
'	Public Shared Function ssicoll(Of CT)(ByVal sz1 As CT, ByVal nLen1 As Integer, ByVal sz2 As CT, ByVal nLen2 As Integer) As Integer
'		Const loc As std.locale
'		Const coll As std.collate(Of CT) = SS_USE_FACET(loc, std.collate(Of CT))

'		' Some implementations seem to have trouble using the collate<>
'		' facet typedefs so we'll just default to basic_string and hope
'		' that's what the collate facet uses (which it generally should)

'	'	std::collate<CT>::string_type s1(sz1);
'	'	std::collate<CT>::string_type s2(sz2);
'		Const sEmpty As std.basic_string(Of CT)
'		Dim s1 As New std.basic_string(Of CT)(If(sz1, sz1, sEmpty.c_str()))
'		Dim s2 As New std.basic_string(Of CT)(If(sz2, sz2, sEmpty.c_str()))

''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
'		sslwr(const_cast<CT*>(s1.c_str()), nLen1, loc)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
'		sslwr(const_cast<CT*>(s2.c_str()), nLen2, loc)
'		Return coll.compare(s2.c_str(), s2.c_str()+nLen2, s1.c_str(), s1.c_str()+nLen1)
'	End Function
'	#End If


'	' -----------------------------------------------------------------------------
'	' ssfmtmsg: FormatMessage equivalents.  Needed because I added a CString facade
'	' Again -- no equivalent of these on non-Win32 builds but their might one day
'	' be one if the message facet gets implemented
'	' -----------------------------------------------------------------------------
'	#If SS_WIN32 AndAlso (Not SS_ANSI) Then
'		Public Shared Function ssfmtmsg(ByVal dwFlags As UInteger, ByVal pSrc As IntPtr, ByVal dwMsgId As UInteger, ByVal dwLangId As UInteger, ByRef pBuf As std.codecvt, ByVal nSize As UInteger, ByRef vlArgs As va_list) As UInteger
'			Return FormatMessageA(dwFlags, pSrc, dwMsgId, dwLangId, pBuf, nSize,vlArgs)
'		End Function
'		Public Shared Function ssfmtmsg(ByVal dwFlags As UInteger, ByVal pSrc As IntPtr, ByVal dwMsgId As UInteger, ByVal dwLangId As UInteger, ByRef pBuf As std.codecvt, ByVal nSize As UInteger, ByRef vlArgs As va_list) As UInteger
'			Return FormatMessageW(dwFlags, pSrc, dwMsgId, dwLangId, pBuf, nSize,vlArgs)
'		End Function
'	#Else
'	#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>



'	' FUNCTION: sscpy.  Copies up to 'nMax' characters from pSrc to pDst.
'	' -----------------------------------------------------------------------------
'	' FUNCTION:  sscpy
'	'		inline int sscpy(PSTR pDst, PCSTR pSrc, int nMax=-1);
'	'		inline int sscpy(PUSTR pDst,  PCSTR pSrc, int nMax=-1)
'	'		inline int sscpy(PSTR pDst, PCWSTR pSrc, int nMax=-1);
'	'		inline int sscpy(PWSTR pDst, PCWSTR pSrc, int nMax=-1);
'	'		inline int sscpy(PWSTR pDst, PCSTR pSrc, int nMax=-1);
'	'
'	' DESCRIPTION:
'	'		This function is very much (but not exactly) like strcpy.  These
'	'		overloads simplify copying one C-style string into another by allowing
'	'		the caller to specify two different types of strings if necessary.
'	'
'	'		The strings must NOT overlap
'	'
'	'		"Character" is expressed in terms of the destination string, not
'	'		the source.  If no 'nMax' argument is supplied, then the number of
'	'		characters copied will be sslen(pSrc).  A NULL terminator will
'	'		also be added so pDst must actually be big enough to hold nMax+1
'	'		characters.  The return value is the number of characters copied,
'	'		not including the NULL terminator.
'	'
'	' PARAMETERS: 
'	'		pSrc - the string to be copied FROM.  May be a char based string, an
'	'			   MBCS string (in Win32 builds) or a wide string (wchar_t).
'	'		pSrc - the string to be copied TO.  Also may be either MBCS or wide
'	'		nMax - the maximum number of characters to be copied into szDest.  Note
'	'			   that this is expressed in whatever a "character" means to pDst.
'	'			   If pDst is a wchar_t type string than this will be the maximum
'	'			   number of wchar_ts that my be copied.  The pDst string must be
'	'			   large enough to hold least nMaxChars+1 characters.
'	'			   If the caller supplies no argument for nMax this is a signal to
'	'			   the routine to copy all the characters in pSrc, regardless of
'	'			   how long it is.
'	'
'	' RETURN VALUE: none
'	' -----------------------------------------------------------------------------
'	Public Shared Function sscpycvt(Of CT1, CT2)(ByRef pDst As CT1, ByVal pSrc As CT2, ByVal nMax As Integer) As Integer
'		' Note -- we assume pDst is big enough to hold pSrc.  If not, we're in
'		' big trouble.  No bounds checking.  Caveat emptor.

'		Dim nSrc As Integer = sslen(pSrc)

'		Const szCvt As CT1 = StdCodeCvt(pDst, nMax, pSrc, nSrc)

'		' If we're copying the same size characters, then all the "code convert"
'		' just did was basically memcpy so the #of characters copied is the same
'		' as the number requested.  I should probably specialize this function
'		' template to achieve this purpose as it is silly to do a runtime check
'		' of a fact known at compile time.  I'll get around to it.

'		Return sslen(szCvt)
'	End Function

'	Public Shared Function sscpycvt(ByRef pDst As std.codecvt, ByVal pSrc As std.codecvt, ByVal nMax As Integer) As Integer
'		Dim nCount As Integer = nMax
'		Do While nCount > 0 AndAlso pSrc IsNot Nothing
'			std.basic_string<std.codecvt(Of ).traits_type.assign(pDst, pSrc)
'		pSrc += 1
'		pDst += 1
'		nCount -= 1
'		Loop

'		pDst = ControlChars.NullChar
'		Return nMax - nCount
'	End Function
'	Public Shared Function sscpycvt(ByRef pDst As std.codecvt, ByVal pSrc As std.codecvt, ByVal nMax As Integer) As Integer
'		Dim nCount As Integer = nMax
'		Do While nCount > 0 AndAlso pSrc IsNot Nothing
'			std.basic_string<std.codecvt(Of ).traits_type.assign(pDst, pSrc)
'		pSrc += 1
'		pDst += 1
'		nCount -= 1
'		Loop

'		pDst = LControlChars.NullChar
'		Return nMax - nCount
'	End Function
'	Public Shared Function sscpycvt(ByRef pDst As std.codecvt, ByVal pSrc As std.codecvt, ByVal nMax As Integer) As Integer
'		' Note -- we assume pDst is big enough to hold pSrc.  If not, we're in
'		' big trouble.  No bounds checking.  Caveat emptor.

'		const std.codecvt<* szCvt = StdCodeCvt(pDst, nMax, pSrc, nMax)
'		Return sslen(szCvt)
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>

'	Public Shared Function sscpy(Of CT1, CT2)(ByRef pDst As CT1, ByVal pSrc As CT2, ByVal nMax As Integer, ByVal nLen As Integer) As Integer
'		Return sscpycvt(pDst, pSrc, SSMIN(nMax, nLen))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>
'	Public Shared Function sscpy(Of CT1, CT2)(ByRef pDst As CT1, ByVal pSrc As CT2, ByVal nMax As Integer) As Integer
'		Return sscpycvt(pDst, pSrc, SSMIN(nMax, sslen(pSrc)))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>
'	Public Shared Function sscpy(Of CT1, CT2)(ByRef pDst As CT1, ByVal pSrc As CT2) As Integer
'		Return sscpycvt(pDst, pSrc, sslen(pSrc))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>
'	Public Shared Function sscpy(Of CT1, CT2)(ByRef pDst As CT1, ByVal sSrc As std.basic_string(Of CT2), ByVal nMax As Integer) As Integer
'		Return sscpycvt(pDst, sSrc.c_str(), SSMIN(nMax, CInt(Fix(sSrc.length()))))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1, typename CT2>
'	Public Shared Function sscpy(Of CT1, CT2)(ByRef pDst As CT1, ByVal sSrc As std.basic_string(Of CT2)) As Integer
'		Return sscpycvt(pDst, sSrc.c_str(), CInt(Fix(sSrc.length())))
'	End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1>

'	#If SS_INC_COMDEF Then
'		Public Shared Function sscpy(Of CT1)(ByRef pDst As CT1, ByVal bs As _bstr_t, ByVal nMax As Integer) As Integer
'			Return sscpycvt(pDst, static_cast<const std.codecvt(Of )(bs), SSMIN(nMax, CInt(Fix(bs.length()))))
'		End Function
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT1>
'		Public Shared Function sscpy(Of CT1)(ByRef pDst As CT1, ByVal bs As _bstr_t) As Integer
'			Return sscpy(pDst, bs, CInt(Fix(bs.length())))
'		End Function
'	#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'	' -----------------------------------------------------------------------------
'	' MSVC USERS: HOW TO EXPORT CSTDSTRING FROM A DLL
'	'
'	' If you are using MS Visual C++ and you want to export CStdStringA and
'	' CStdStringW from a DLL, then all you need to
'	'
'	'		1.	make sure that all components link to the same DLL version
'	'			of the CRT (not the static one).
'	'		2.	Uncomment the 3 lines of code below
'	'		3.	#define 2 macros per the instructions in MS KnowledgeBase
'	'			article Q168958.  The macros are:
'	'
'	'		MACRO		DEFINTION WHEN EXPORTING		DEFINITION WHEN IMPORTING
'	'		-----		------------------------		-------------------------
'	'		SSDLLEXP	(nothing, just #define it)		extern
'	'		SSDLLSPEC	__declspec(dllexport)			__declspec(dllimport)
'	'
'	'		Note that these macros must be available to ALL clients who want to 
'	'		link to the DLL and use the class.  If they 
'	'
'	' A word of advice: Don't bother.
'	'
'	' Really, it is not necessary to export CStdString functions from a DLL.  I
'	' never do.  In my projects, I do generally link to the DLL version of the
'	' Standard C++ Library, but I do NOT attempt to export CStdString functions.
'	' I simply include the header where it is needed and allow for the code
'	' redundancy.
'	'
'	' That redundancy is a lot less than you think.  This class does most of its
'	' work via the Standard C++ Library, particularly the base_class basic_string<>
'	' member functions.  Most of the functions here are small enough to be inlined
'	' anyway.  Besides, you'll find that in actual practice you use less than 1/2
'	' of the code here, even in big projects and different modules will use as
'	' little as 10% of it.  That means a lot less functions actually get linked
'	' your binaries.  If you export this code from a DLL, it ALL gets linked in.
'	'
'	' I've compared the size of the binaries from exporting vs NOT exporting.  Take
'	' my word for it -- exporting this code is not worth the hassle.
'	'
'	' -----------------------------------------------------------------------------
'	'#pragma warning(disable:4231) // non-standard extension ("extern template")
'	'	SSDLLEXP template class SSDLLSPEC CStdStr<char>;
'	'	SSDLLEXP template class SSDLLSPEC CStdStr<wchar_t>;


'	' =============================================================================
'	'						END OF CStdStr INLINE FUNCTION DEFINITIONS
'	' =============================================================================

'	'	Now typedef our class names based upon this humongous template


'	' -----------------------------------------------------------------------------
'	' CStdStr addition functions defined as inline
'	' -----------------------------------------------------------------------------


'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal s2 As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(s2)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal t As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(1, t)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal pA As std.codecvt) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(pA)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal pA As std.codecvt, ByVal sA As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet
'		CStdStr<std.codecvt(Of ).size_type nObjSize = sA.size()
'		CStdStr<std.codecvt(Of ).size_type nLitSize = static_cast<New CStdStr(Of std.codecvt(Of ).size_type)(sslen(pA))

'		sRet.reserve(nLitSize + nObjSize)
'		sRet.assign(pA)
'		sRet.append(sA)
'		Return sRet
'	End Operator


'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal s2 As CStdStr(Of )) As std.codecvt(Of )
'		Return s1 + CStdStr<std.codecvt(Of )(s2)
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal s2 As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(s2)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal pW As std.codecvt) As std.codecvt(Of )
'		Return s1 + CStdStr<std.codecvt(Of )(pW)
'	End Operator

'	#If UNICODE Then
'		Public Shared CStdStr<Operator +(ByVal pW As std.codecvt, ByVal sA As CStdStr(Of )) As std.codecvt(Of )
'			Return CStdStr<std.codecvt(Of )(pW) + CStdStr<std.codecvt(Of )((sA))
'		End Operator
'		Public Shared CStdStr<Operator +(ByVal pA As std.codecvt, ByVal sW As CStdStr(Of )) As std.codecvt(Of )
'			Return CStdStr<std.codecvt(Of )(pA) + sW
'		End Operator
'	#Else
'		Public Shared CStdStr<Operator +(ByVal pW As std.codecvt, ByVal sA As CStdStr(Of )) As std.codecvt(Of )
'			Return CStdStr<std.codecvt(Of )(pW) + sA
'		End Operator
'		Public Shared CStdStr<Operator +(ByVal pA As std.codecvt, ByVal sW As CStdStr(Of )) As std.codecvt(Of )
'			Return pA + CStdStr<std.codecvt(Of )(sW)
'		End Operator
'	#End If

'	' ...Now the wide string versions.
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal t As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(1, t)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal pW As std.codecvt) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet((s1))
'		sRet.append(pW)
'		Return sRet
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal pW As std.codecvt, ByVal sW As CStdStr(Of )) As std.codecvt(Of )
'		CStdStr<std.codecvt(Of ) sRet
'		CStdStr<std.codecvt(Of ).size_type nObjSize = sW.size()
'		CStdStr<std.codecvt(Of ).size_type nLitSize = static_cast<New CStdStr(Of std.codecvt(Of ).size_type)(sslen(pW))

'		sRet.reserve(nLitSize + nObjSize)
'		sRet.assign(pW)
'		sRet.append(sW)
'		Return sRet
'	End Operator

'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal s2 As CStdStr(Of )) As std.codecvt(Of )
'		Return s1 + CStdStr<std.codecvt(Of )(s2)
'	End Operator
'	Public Shared CStdStr<Operator +(ByVal s1 As CStdStr(Of ), ByVal pA As std.codecvt) As std.codecvt(Of )
'		Return s1 + CStdStr<std.codecvt(Of )(pA)
'	End Operator

'	#If Not SS_ANSI Then
'		' SSResourceHandle: our MFC-like resource handle
'		Public Shared Function SSResourceHandle() As IntPtr
'			Static hModuleSS As IntPtr = GetModuleHandle(0)
'			Return hModuleSS
'		End Function
'	#End If


'	' In MFC builds, define some global serialization operators
'	' Special operators that allow us to serialize CStdStrings to CArchives.
'	' Note that we use an intermediate CString object in order to ensure that
'	' we use the exact same format.

'	#If _MFC_VER Then
'		Public Shared CArchive And Operator <<(ByRef ar As CArchive, ByVal strA As CStdStr(Of )) As AFXAPI
'			Dim strTemp As String = strA
'			Return ar << strTemp
'		End Operator
'		Public Shared CArchive And Operator <<(ByRef ar As CArchive, ByVal strW As CStdStr(Of )) As AFXAPI
'			Dim strTemp As String = strW
'			Return ar << strTemp
'		End Operator

'		Public Shared CArchive And Operator >>(ByRef ar As CArchive, ByRef strA As CStdStr(Of )) As AFXAPI
'			Dim strTemp As String
'			ar >> strTemp
'			strA = strTemp
'			Return ar
'		End Operator
'		Public Shared CArchive And Operator >>(ByRef ar As CArchive, ByRef strW As CStdStr(Of )) As AFXAPI
'			Dim strTemp As String
'			ar >> strTemp
'			strW = strTemp
'			Return ar
'		End Operator
'	#End If ' #ifdef _MFC_VER -- (i.e. is this MFC?)



'	' -----------------------------------------------------------------------------
'	' GLOBAL FUNCTION:  WUFormat
'	'		CStdStringA WUFormat(UINT nId, ...);
'	'		CStdStringA WUFormat(PCSTR szFormat, ...);
'	'
'	' REMARKS:
'	'		This function allows the caller for format and return a CStdStringA
'	'		object with a single line of code.
'	' -----------------------------------------------------------------------------
'	#If SS_ANSI Then
'	#Else
'		Public Shared CStdStr<Function WUFormatA(ByVal nId As UInteger, ParamArray ByVal LegacyParamArray() As Object) As std.codecvt(Of )
'	'		Dim argList As va_list
'		Dim ParamCount As Integer = -1
'	'		va_start(argList, nId)

'			CStdStr<std.codecvt(Of ) strFmt
'			CStdStr<std.codecvt(Of ) strOut
'			If strFmt.Load(nId) Then
'				strOut.FormatV(strFmt, argList)
'			End If

'	'		va_end(argList)
'			Return strOut
'		End Function
'		Public Shared CStdStr<Function WUFormatA(ByVal szFormat As std.codecvt, ParamArray ByVal LegacyParamArray() As Object) As std.codecvt(Of )
'	'		Dim argList As va_list
'		Dim ParamCount As Integer = -1
'	'		va_start(argList, szFormat)
'			CStdStr<std.codecvt(Of ) strOut
'			strOut.FormatV(szFormat, argList)
'	'		va_end(argList)
'			Return strOut
'		End Function
'		Public Shared CStdStr<Function WUFormatW(ByVal nId As UInteger, ParamArray ByVal LegacyParamArray() As Object) As std.codecvt(Of )
'	'		Dim argList As va_list
'		Dim ParamCount As Integer = -1
'	'		va_start(argList, nId)

'			CStdStr<std.codecvt(Of ) strFmt
'			CStdStr<std.codecvt(Of ) strOut
'			If strFmt.Load(nId) Then
'				strOut.FormatV(strFmt, argList)
'			End If

'	'		va_end(argList)
'			Return strOut
'		End Function
'		Public Shared CStdStr<Function WUFormatW(ByVal szwFormat As std.codecvt, ParamArray ByVal LegacyParamArray() As Object) As std.codecvt(Of )
'	'		Dim argList As va_list
'		Dim ParamCount As Integer = -1
'	'		va_start(argList, szwFormat)
'			CStdStr<std.codecvt(Of ) strOut
'			strOut.FormatV(szwFormat, argList)
'	'		va_end(argList)
'			Return strOut
'		End Function
'	#End If ' #ifdef SS_ANSI



'	#If SS_WIN32 AndAlso (Not SS_ANSI) Then
'		' -------------------------------------------------------------------------
'		' FUNCTION: WUSysMessage
'		'	 CStdStringA WUSysMessageA(DWORD dwError, DWORD dwLangId=SS_DEFLANGID);
'		'	 CStdStringW WUSysMessageW(DWORD dwError, DWORD dwLangId=SS_DEFLANGID);
'		'           
'		' DESCRIPTION:
'		'	 This function simplifies the process of obtaining a string equivalent
'		'	 of a system error code returned from GetLastError().  You simply
'		'	 supply the value returned by GetLastError() to this function and the
'		'	 corresponding system string is returned in the form of a CStdStringA.
'		'
'		' PARAMETERS: 
'		'	 dwError - a DWORD value representing the error code to be translated
'		'	 dwLangId - the language id to use.  defaults to english.
'		'
'		' RETURN VALUE: 
'		'	 a CStdStringA equivalent of the error code.  Currently, this function
'		'	 only returns either English of the system default language strings.  
'		' -------------------------------------------------------------------------
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define SS_DEFLANGID MAKELANGID(LANG_NEUTRAL,SUBLANG_DEFAULT)
'		#Const SS_DEFLANGID = True
'		Public Shared CStdStr<Function WUSysMessageA(ByVal dwError As UInteger, Optional ByVal dwLangId As UInteger = MAKELANGID(LANG_NEUTRAL,SUBLANG_DEFAULT)) As std.codecvt(Of )
'			Dim szBuf As New String(New Char(511){})

'			If 0 <>FormatMessageA(FORMAT_MESSAGE_FROM_SYSTEM, Nothing, dwError, dwLangId, szBuf, 511, Nothing) Then
'				Return WUFormatA("%s (0x%X)", szBuf, dwError)
'			Else
'				 Return WUFormatA("Unknown error (0x%X)", dwError)
'			End If
'		End Function
'		Public Shared CStdStr<Function WUSysMessageW(ByVal dwError As UInteger, Optional ByVal dwLangId As UInteger = MAKELANGID(LANG_NEUTRAL,SUBLANG_DEFAULT)) As std.codecvt(Of )
'			Dim szBuf(511) As Char

'			If 0 <>FormatMessageW(FORMAT_MESSAGE_FROM_SYSTEM, Nothing, dwError, dwLangId, szBuf, 511, Nothing) Then
'				Return WUFormatW("%s (0x%X)", szBuf, dwError)
'			Else
'				 Return WUFormatW("Unknown error (0x%X)", dwError)
'			End If
'		End Function
'	#End If

'	' Define TCHAR based friendly names for some of these functions

'	#If UNICODE Then
'		'#define CStdString				CStdStringW
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUSysMessage WUSysMessageW
'		#Const WUSysMessage = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUFormat WUFormatW
'		#Const WUFormat = True
'	#Else
'		'#define CStdString				CStdStringA
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUSysMessage WUSysMessageA
'		#Const WUSysMessage = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUFormat WUFormatA
'		#Const WUFormat = True
'	#End If

'	' ...and some shorter names for the space-efficient

'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUSysMsg WUSysMessage
'	#Const WUSysMsg = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUSysMsgA WUSysMessageA
'	#Const WUSysMsgA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUSysMsgW WUSysMessageW
'	#Const WUSysMsgW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUFmtA WUFormatA
'	#Const WUFmtA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUFmtW WUFormatW
'	#Const WUFmtW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WUFmt WUFormat
'	#Const WUFmt = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WULastErrMsg() WUSysMessage(::GetLastError())
'	#Const WULastErrMsg = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WULastErrMsgA() WUSysMessageA(::GetLastError())
'	#Const WULastErrMsgA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define WULastErrMsgW() WUSysMessageW(::GetLastError())
'	#Const WULastErrMsgW = True


'	' -----------------------------------------------------------------------------
'	' FUNCTIONAL COMPARATORS:
'	' REMARKS:
'	'		These structs are derived from the std::binary_function template.  They
'	'		give us functional classes (which may be used in Standard C++ Library
'	'		collections and algorithms) that perform case-insensitive comparisons of
'	'		CStdString objects.  This is useful for maps in which the key may be the
'	'		 proper string but in the wrong case.
'	' -----------------------------------------------------------------------------
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringLessNoCaseW SSLNCW
'	#Const StdStringLessNoCaseW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringEqualsNoCaseW SSENCW
'	#Const StdStringEqualsNoCaseW = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringLessNoCaseA SSLNCA
'	#Const StdStringLessNoCaseA = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringEqualsNoCaseA SSENCA
'	#Const StdStringEqualsNoCaseA = True

'	#If UNICODE Then
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringLessNoCase SSLNCW
'		#Const StdStringLessNoCase = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringEqualsNoCase SSENCW
'		#Const StdStringEqualsNoCase = True
'	#Else
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringLessNoCase SSLNCA
'		#Const StdStringLessNoCase = True
'	'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
'	'ORIGINAL LINE: #define StdStringEqualsNoCase SSENCA
'		#Const StdStringEqualsNoCase = True
'	#End If
'	  ' GCC does something stupid with optimization on release builds if we try 
'	  ' to assert in these functions
'	  Public Shared Function round_int(ByVal x As Double) As Integer
'		Debug.Assert(x > CDbl(INT_MIN / 2) - 1.0)
'		Debug.Assert(x < CDbl(INT_MAX / 2) + 1.0)
'		Const round_to_nearest As Single = 0.5f
'		Dim i As Integer

'	#If Not _LINUX Then
'		__asm
'		  fld x fadd st, st (0) fadd round_to_nearest fistp i sar i, 1
'	#Else
'		#If __APPLE__ OrElse __powerpc__ Then
'			i = Math.Floor(x + round_to_nearest)
'		#Else
'			Dim __volatile__ As New __asm__("fadd %%st" & Constants.vbLf + Constants.vbTab "fadd %%st(1)" & Constants.vbLf + Constants.vbTab "fistpl %0" & Constants.vbLf + Constants.vbTab "sarl $1, %0" & Constants.vbLf : "=m".Chars(i) : "u".Chars(round_to_nearest), "t".Chars(x) : "st")
'		#End If
'	#End If
'		Return (i)
'	  End Function

'	  Public Shared Function ceil_int(ByVal x As Double) As Integer
'		Debug.Assert(x > CDbl(INT_MIN / 2) - 1.0)
'		Debug.Assert(x < CDbl(INT_MAX / 2) + 1.0)

'		#If Not __APPLE__ Then
'			Const round_towards_p_i As Single = -0.5f
'		#End If
'		Dim i As Integer

'	#If Not _LINUX Then
'		__asm
'		  fld x fadd st, st (0) fsubr round_towards_p_i fistp i sar i, 1
'	#Else
'		#If __APPLE__ Then
'			i = Math.Ceiling(x)
'		#Else
'			Dim __volatile__ As New __asm__("fadd %%st" & Constants.vbLf + Constants.vbTab "fsubr %%st(1)" & Constants.vbLf + Constants.vbTab "fistpl %0" & Constants.vbLf + Constants.vbTab "sarl $1, %0" & Constants.vbLf : "=m".Chars(i) : "u".Chars(round_towards_p_i), "t".Chars(x) : "st")
'		#End If
'	#End If
'		Return (-i)
'	  End Function

'	  Public Shared Function truncate_int(ByVal x As Double) As Integer
'		Debug.Assert(x > CDbl(INT_MIN / 2) - 1.0)
'		Debug.Assert(x < CDbl(INT_MAX / 2) + 1.0)

'		#If Not __APPLE__ Then
'			Const round_towards_m_i As Single = -0.5f
'		#End If
'		Dim i As Integer

'	#If Not _LINUX Then
'		__asm
'		  fld x fadd st, st (0) fabs fadd round_towards_m_i fistp i sar i, 1
'	#Else
'		#If __APPLE__ Then
'			i = CInt(Fix(x))
'		#Else
'			Dim __volatile__ As New __asm__("fadd %%st" & Constants.vbLf + Constants.vbTab "fabs" & Constants.vbLf + Constants.vbTab "fadd %%st(1)" & Constants.vbLf + Constants.vbTab "fistpl %0" & Constants.vbLf + Constants.vbTab "sarl $1, %0" & Constants.vbLf : "=m".Chars(i) : "u".Chars(round_towards_m_i), "t".Chars(x) : "st")
'		#End If
'	#End If
'		If x < 0 Then
'		  i = -i
'		End If
'		Return (i)
'	  End Function

'	  Public Shared Sub hack()
'		' stupid hack to keep compiler from dropping these
'		' functions as unused
'		MathUtils.round_int(0.0)
'		MathUtils.truncate_int(0.0)
'		MathUtils.ceil_int(0.0)
'	  End Sub
'End Class
''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'#If Not SCRAPER_PARSER_H Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SCRAPER_PARSER_H
'#Const SCRAPER_PARSER_H = True

''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'#If (Not _LINUX) Then
'#End If

'' =============================================================================
''  FILE:  StdString.h
''  AUTHOR:	Joe O'Leary (with outside help noted in comments)
''
''		If you find any bugs in this code, please let me know:
''
''				jmoleary@earthlink.net
''				http://www.joeo.net/stdstring.htm (a bit outdated)
''
''      The latest version of this code should always be available at the
''      following link:
''
''              http://www.joeo.net/code/StdString.zip (Dec 6, 2003)
''
''
''  REMARKS:
''		This header file declares the CStdStr template.  This template derives
''		the Standard C++ Library basic_string<> template and add to it the
''		the following conveniences:
''			- The full MFC CString set of functions (including implicit cast)
''			- writing to/reading from COM IStream interfaces
''			- Functional objects for use in STL algorithms
''
''		From this template, we intstantiate two classes:  CStdStringA and
''		CStdStringW.  The name "CStdString" is just a #define of one of these,
''		based upone the UNICODE macro setting
''
''		This header also declares our own version of the MFC/ATL UNICODE-MBCS
''		conversion macros.  Our version looks exactly like the Microsoft's to
''		facilitate portability.
''
''	NOTE:
''		If you you use this in an MFC or ATL build, you should include either
''		afx.h or atlbase.h first, as appropriate.
''
''	PEOPLE WHO HAVE CONTRIBUTED TO THIS CLASS:
''
''		Several people have helped me iron out problems and othewise improve
''		this class.  OK, this is a long list but in my own defense, this code
''		has undergone two major rewrites.  Many of the improvements became
''		necessary after I rewrote the code as a template.  Others helped me
''		improve the CString facade.
''
''		Anyway, these people are (in chronological order):
''
''			- Pete the Plumber (???)
''			- Julian Selman
''			- Chris (of Melbsys)
''			- Dave Plummer
''			- John C Sipos
''			- Chris Sells
''			- Nigel Nunn
''			- Fan Xia
''			- Matthew Williams
''			- Carl Engman
''			- Mark Zeren
''			- Craig Watson
''			- Rich Zuris
''			- Karim Ratib
''			- Chris Conti
''			- Baptiste Lepilleur
''			- Greg Pickles
''			- Jim Cline
''			- Jeff Kohn
''			- Todd Heckel
''			- Ullrich Pollï¿½hne
''			- Joe Vitaterna
''			- Joe Woodbury
''			- Aaron (no last name)
''			- Joldakowski (???)
''			- Scott Hathaway
''			- Eric Nitzche
''			- Pablo Presedo
''			- Farrokh Nejadlotfi
''			- Jason Mills
''			- Igor Kholodov
''			- Mike Crusader
''			- John James
''			- Wang Haifeng
''			- Tim Dowty
''          - Arnt Witteveen
''          - Glen Maynard
''          - Paul DeMarco
''          - Bagira (full name?)
''          - Ronny Schulz
''          - Jakko Van Hunen
''			- Charles Godwin
''			- Henk Demper
''			- Greg Marr
''			- Bill Carducci
''			- Brian Groose
''			- MKingman
''			- Don Beusee
''
''	REVISION HISTORY
''
''	  2005-JAN-10 - Thanks to Don Beusee for pointing out the danger in mapping
''					length-checked formatting functions to non-length-checked
''					CRT equivalents.  Also thanks to him for motivating me to
''					optimize my implementation of Replace()
''
''	  2004-APR-22 - A big, big thank you to "MKingman" (whoever you are) for
''					finally spotting a silly little error in StdCodeCvt that
''					has been causing me (and users of CStdString) problems for
''					years in some relatively rare conversions.  I had reversed
''					two length arguments. 
''
''    2003-NOV-24 - Thanks to a bunch of people for helping me clean up many
''					compiler warnings (and yes, even a couple of actual compiler
''					errors).  These include Henk Demper for figuring out how
''					to make the Intellisense work on with CStdString on VC6,
''					something I was never able to do.  Greg Marr pointed out
''					a compiler warning about an unreferenced symbol and a
''					problem with my version of Load in MFC builds.  Bill
''					Carducci took a lot of time with me to help me figure out
''					why some implementations of the Standard C++ Library were
''					returning error codes for apparently successful conversions
''					between ASCII and UNICODE.  Finally thanks to Brian Groose
''					for helping me fix compiler signed unsigned warnings in
''					several functions.
''
''    2003-JUL-10 - Thanks to Charles Godwin for making me realize my 'FmtArg'
''					fixes had inadvertently broken the DLL-export code (which is
''                  normally commented out.  I had to move it up higher.  Also
''					this helped me catch a bug in ssicoll that would prevent
''                  compilation, otherwise.
''
''    2003-MAR-14 - Thanks to Jakko Van Hunen for pointing out a copy-and-paste
''                  bug in one of the overloads of FmtArg.
''
''    2003-MAR-10 - Thanks to Ronny Schulz for (twice!) sending me some changes
''                  to help CStdString build on SGI and for pointing out an
''                  error in placement of my preprocessor macros for ssfmtmsg.
''
''    2002-NOV-26 - Thanks to Bagira for pointing out that my implementation of
''                  SpanExcluding was not properly handling the case in which
''                  the string did NOT contain any of the given characters
''
''    2002-OCT-21 - Many thanks to Paul DeMarco who was invaluable in helping me
''                  get this code working with Borland's free compiler as well
''                  as the Dev-C++ compiler (available free at SourceForge).
''
''    2002-SEP-13 - Thanks to Glen Maynard who helped me get rid of some loud
''                  but harmless warnings that were showing up on g++.  Glen
''                  also pointed out that some pre-declarations of FmtArg<>
''                  specializations were unnecessary (and no good on G++)
''
''    2002-JUN-26 - Thanks to Arnt Witteveen for pointing out that I was using
''                  static_cast<> in a place in which I should have been using
''                  reinterpret_cast<> (the ctor for unsigned char strings).
''                  That's what happens when I don't unit-test properly!
''                  Arnt also noticed that CString was silently correcting the
''                  'nCount' argument to Left() and Right() where CStdString was
''                  not (and crashing if it was bad).  That is also now fixed!
''
''	  2002-FEB-25 - Thanks to Tim Dowty for pointing out (and giving me the fix
''					for) a conversion problem with non-ASCII MBCS characters.
''					CStdString is now used in my favorite commercial MP3 player!
''
''	  2001-DEC-06 - Thanks to Wang Haifeng for spotting a problem in one of the
''					assignment operators (for _bstr_t) that would cause compiler
''					errors when refcounting protection was turned off.
''
''	  2001-NOV-27 - Remove calls to operator!= which involve reverse_iterators
''					due to a conflict with the rel_ops operator!=.  Thanks to
''					John James for pointing this out.
''
''    2001-OCT-29 - Added a minor range checking fix for the Mid function to
''					make it as forgiving as CString's version is.  Thanks to
''					Igor Kholodov for noticing this.  
''				  - Added a specialization of std::swap for CStdString.  Thanks
''					to Mike Crusader for suggesting this!  It's commented out
''					because you're not supposed to inject your own code into the
''					'std' namespace.  But if you don't care about that, it's
''					there if you want it
''				  - Thanks to Jason Mills for catching a case where CString was
''					more forgiving in the Delete() function than I was.
''
''	  2001-JUN-06 - I was violating the Standard name lookup rules stated
''					in [14.6.2(3)].  None of the compilers I've tried so
''					far apparently caught this but HP-UX aCC 3.30 did.  The
''					fix was to add 'this->' prefixes in many places.
''					Thanks to Farrokh Nejadlotfi for this!
''
''	  2001-APR-27 - StreamLoad was calculating the number of BYTES in one
''					case, not characters.  Thanks to Pablo Presedo for this.
''
''    2001-FEB-23 - Replace() had a bug which caused infinite loops if the
''					source string was empty.  Fixed thanks to Eric Nitzsche.
''
''    2001-FEB-23 - Scott Hathaway was a huge help in providing me with the
''					ability to build CStdString on Sun Unix systems.  He
''					sent me detailed build reports about what works and what
''					does not.  If CStdString compiles on your Unix box, you
''					can thank Scott for it.
''
''	  2000-DEC-29 - Joldakowski noticed one overload of Insert failed to do a
''					range check as CString's does.  Now fixed -- thanks!
''
''	  2000-NOV-07 - Aaron pointed out that I was calling static member
''					functions of char_traits via a temporary.  This was not
''					technically wrong, but it was unnecessary and caused
''					problems for poor old buggy VC5.  Thanks Aaron!
''
''	  2000-JUL-11 - Joe Woodbury noted that the CString::Find docs don't match
''					what the CString::Find code really ends up doing.   I was
''					trying to match the docs.  Now I match the CString code
''				  - Joe also caught me truncating strings for GetBuffer() calls
''					when the supplied length was less than the current length.
''
''	  2000-MAY-25 - Better support for STLPORT's Standard library distribution
''				  - Got rid of the NSP macro - it interfered with Koenig lookup
''				  - Thanks to Joe Woodbury for catching a TrimLeft() bug that
''					I introduced in January.  Empty strings were not getting
''					trimmed
''
''	  2000-APR-17 - Thanks to Joe Vitaterna for pointing out that ReverseFind
''					is supposed to be a const function.
''
''	  2000-MAR-07 - Thanks to Ullrich Pollï¿½hne for catching a range bug in one
''					of the overloads of assign.
''
''    2000-FEB-01 - You can now use CStdString on the Mac with CodeWarrior!
''					Thanks to Todd Heckel for helping out with this.
''
''	  2000-JAN-23 - Thanks to Jim Cline for pointing out how I could make the
''					Trim() function more efficient.
''				  - Thanks to Jeff Kohn for prompting me to find and fix a typo
''					in one of the addition operators that takes _bstr_t.
''				  - Got rid of the .CPP file -  you only need StdString.h now!
''
''	  1999-DEC-22 - Thanks to Greg Pickles for helping me identify a problem
''					with my implementation of CStdString::FormatV in which
''					resulting string might not be properly NULL terminated.
''
''	  1999-DEC-06 - Chris Conti pointed yet another basic_string<> assignment
''					bug that MS has not fixed.  CStdString did nothing to fix
''					it either but it does now!  The bug was: create a string
''					longer than 31 characters, get a pointer to it (via c_str())
''					and then assign that pointer to the original string object.
''					The resulting string would be empty.  Not with CStdString!
''
''	  1999-OCT-06 - BufferSet was erasing the string even when it was merely
''					supposed to shrink it.  Fixed.  Thanks to Chris Conti.
''				  - Some of the Q172398 fixes were not checking for assignment-
''					to-self.  Fixed.  Thanks to Baptiste Lepilleur.
''
''	  1999-AUG-20 - Improved Load() function to be more efficient by using 
''					SizeOfResource().  Thanks to Rich Zuris for this.
''				  - Corrected resource ID constructor, again thanks to Rich.
''				  - Fixed a bug that occurred with UNICODE characters above
''					the first 255 ANSI ones.  Thanks to Craig Watson. 
''				  - Added missing overloads of TrimLeft() and TrimRight().
''					Thanks to Karim Ratib for pointing them out
''
''	  1999-JUL-21 - Made all calls to GetBuf() with no args check length first.
''
''	  1999-JUL-10 - Improved MFC/ATL independence of conversion macros
''				  - Added SS_NO_REFCOUNT macro to allow you to disable any
''					reference-counting your basic_string<> impl. may do.
''				  - Improved ReleaseBuffer() to be as forgiving as CString.
''					Thanks for Fan Xia for helping me find this and to
''					Matthew Williams for pointing it out directly.
''
''	  1999-JUL-06 - Thanks to Nigel Nunn for catching a very sneaky bug in
''					ToLower/ToUpper.  They should call GetBuf() instead of
''					data() in order to ensure the changed string buffer is not
''					reference-counted (in those implementations that refcount).
''
''	  1999-JUL-01 - Added a true CString facade.  Now you can use CStdString as
''					a drop-in replacement for CString.  If you find this useful,
''					you can thank Chris Sells for finally convincing me to give
''					in and implement it.
''				  - Changed operators << and >> (for MFC CArchive) to serialize
''					EXACTLY as CString's do.  So now you can send a CString out
''					to a CArchive and later read it in as a CStdString.   I have
''					no idea why you would want to do this but you can. 
''
''	  1999-JUN-21 - Changed the CStdString class into the CStdStr template.
''				  - Fixed FormatV() to correctly decrement the loop counter.
''					This was harmless bug but a bug nevertheless.  Thanks to
''					Chris (of Melbsys) for pointing it out
''				  - Changed Format() to try a normal stack-based array before
''					using to _alloca().
''				  - Updated the text conversion macros to properly use code
''					pages and to fit in better in MFC/ATL builds.  In other
''					words, I copied Microsoft's conversion stuff again. 
''				  - Added equivalents of CString::GetBuffer, GetBufferSetLength
''				  - new sscpy() replacement of CStdString::CopyString()
''				  - a Trim() function that combines TrimRight() and TrimLeft().
''
''	  1999-MAR-13 - Corrected the "NotSpace" functional object to use _istpace()
''					instead of _isspace()   Thanks to Dave Plummer for this.
''
''	  1999-FEB-26 - Removed errant line (left over from testing) that #defined
''					_MFC_VER.  Thanks to John C Sipos for noticing this.
''
''	  1999-FEB-03 - Fixed a bug in a rarely-used overload of operator+() that
''					caused infinite recursion and stack overflow
''				  - Added member functions to simplify the process of
''					persisting CStdStrings to/from DCOM IStream interfaces 
''				  - Added functional objects (e.g. StdStringLessNoCase) that
''					allow CStdStrings to be used as keys STL map objects with
''					case-insensitive comparison 
''				  - Added array indexing operators (i.e. operator[]).  I
''					originally assumed that these were unnecessary and would be
''					inherited from basic_string.  However, without them, Visual
''					C++ complains about ambiguous overloads when you try to use
''					them.  Thanks to Julian Selman to pointing this out. 
''
''	  1998-FEB-?? - Added overloads of assign() function to completely account
''					for Q172398 bug.  Thanks to "Pete the Plumber" for this
''
''	  1998-FEB-?? - Initial submission
''
'' COPYRIGHT:
''		2002 Joseph M. O'Leary.  This code is 100% free.  Use it anywhere you
''      want.  Rewrite it, restructure it, whatever.  If you can write software
''      that makes money off of it, good for you.  I kinda like capitalism. 
''      Please don't blame me if it causes your $30 billion dollar satellite
''      explode in orbit.  If you redistribute it in any form, I'd appreciate it
''      if you would leave this notice here.
'' =============================================================================

'' Avoid multiple inclusion

'#If Not STDSTRING_H Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define STDSTRING_H
'#Const STDSTRING_H = True

'' When using VC, turn off browser references
'' Turn off unavoidable compiler warnings

'#If _MSC_VER AndAlso (_MSC_VER > 1100) Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma component(browser, off, references, "CStdString")
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma warning (disable : 4290) ' C++ Exception Specification ignored
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma warning (disable : 4127) ' Conditional expression is constant
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma warning (disable : 4097) ' typedef name used as synonym for class name
'#End If

'' Borland warnings to turn off

'#If __BORLANDC__ Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma option push -w-inl
''	#pragma warn -inl   // Turn off inline function warnings
'#End If

'' SS_IS_INTRESOURCE
'' -----------------
''		A copy of IS_INTRESOURCE from VC7.  Because old VC6 version of winuser.h
''		doesn't have this.

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_IS_INTRESOURCE(_r) (false)
'#Const SS_IS_INTRESOURCE = True

'#If (Not SS_ANSI) AndAlso _MSC_VER Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''	#undef SS_IS_INTRESOURCE
'	#If _WIN64 Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_IS_INTRESOURCE(_r) (((unsigned __int64)(_r) >> 16) = 0)
'		#Const SS_IS_INTRESOURCE = True
'	#Else
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_IS_INTRESOURCE(_r) (((unsigned long)(_r) >> 16) = 0)
'		#Const SS_IS_INTRESOURCE = True
'	#End If
'#End If


'' MACRO: SS_UNSIGNED
'' ------------------
''      This macro causes the addition of a constructor and assignment operator
''      which take unsigned characters.  CString has such functions and in order
''      to provide maximum CString-compatability, this code needs them as well.
''      In practice you will likely never need these functions...

''#define SS_UNSIGNED

'#If SS_ALLOW_UNSIGNED_CHARS Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_UNSIGNED
'	#Const SS_UNSIGNED = True
'#End If

'' MACRO: SS_SAFE_FORMAT
'' ---------------------
''      This macro provides limited compatability with a questionable CString
''      "feature".  You can define it in order to avoid a common problem that
''      people encounter when switching from CString to CStdString.
''
''      To illustrate the problem -- With CString, you can do this:
''
''          CString sName("Joe");
''          CString sTmp;
''          sTmp.Format("My name is %s", sName);                    // WORKS!
''
''      However if you were to try this with CStdString, your program would
''      crash.
''
''          CStdString sName("Joe");
''          CStdString sTmp;
''          sTmp.Format("My name is %s", sName);                    // CRASHES!
''
''      You must explicitly call c_str() or cast the object to the proper type
''
''          sTmp.Format("My name is %s", sName.c_str());            // WORKS!
''          sTmp.Format("My name is %s", static_cast<PCSTR>(sName));// WORKS!
''          sTmp.Format("My name is %s", (PCSTR)sName);				// WORKS!
''
''      This is because it is illegal to pass anything but a POD type as a
''      variadic argument to a variadic function (i.e. as one of the "..."
''      arguments).  The type const char* is a POD type.  The type CStdString
''      is not.  Of course, neither is the type CString, but CString lets you do
''      it anyway due to the way they laid out the class in binary.  I have no
''      control over this in CStdString since I derive from whatever
''      implementation of basic_string is available.
''
''      However if you have legacy code (which does this) that you want to take
''      out of the MFC world and you don't want to rewrite all your calls to
''      Format(), then you can define this flag and it will no longer crash.
''
''      Note however that this ONLY works for Format(), not sprintf, fprintf, 
''      etc.  If you pass a CStdString object to one of those functions, your
''      program will crash.  Not much I can do to get around this, short of
''      writing substitutes for those functions as well.

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_SAFE_FORMAT
'#Const SS_SAFE_FORMAT = True


'' MACRO: SS_NO_IMPLICIT_CAST
'' --------------------------
''      Some people don't like the implicit cast to const char* (or rather to
''      const CT*) that CStdString (and MFC's CString) provide.  That was the
''      whole reason I created this class in the first place, but hey, whatever
''      bakes your cake.  Just #define this macro to get rid of the the implicit
''      cast.

''#define SS_NO_IMPLICIT_CAST // gets rid of operator const CT*()


'' MACRO: SS_NO_REFCOUNT
'' ---------------------
''		turns off reference counting at the assignment level.  Only needed
''		for the version of basic_string<> that comes with Visual C++ versions
''		6.0 or earlier, and only then in some heavily multithreaded scenarios.
''		Uncomment it if you feel you need it.

''#define SS_NO_REFCOUNT

'' MACRO: SS_WIN32
'' ---------------
''      When this flag is set, we are building code for the Win32 platform and
''      may use Win32 specific functions (such as LoadString).  This gives us
''      a couple of nice extras for the code.
''
''      Obviously, Microsoft's is not the only compiler available for Win32 out
''      there.  So I can't just check to see if _MSC_VER is defined to detect
''      if I'm building on Win32.  So for now, if you use MS Visual C++ or
''      Borland's compiler, I turn this on.  Otherwise you may turn it on
''      yourself, if you prefer

'#If _MSC_VER OrElse __BORLANDC__ OrElse _WIN32 Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_WIN32
' #Const SS_WIN32 = True
'#End If

'' MACRO: SS_ANSI
'' --------------
''      When this macro is defined, the code attempts only to use ANSI/ISO
''      standard library functions to do it's work.  It will NOT attempt to use
''      any Win32 of Visual C++ specific functions -- even if they are
''      available.  You may define this flag yourself to prevent any Win32
''      of VC++ specific functions from being called. 

'' If we're not on Win32, we MUST use an ANSI build

'#If Not SS_WIN32 Then
'	#If (Not SS_NO_ANSI) Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_ANSI
'		#Const SS_ANSI = True
'	#End If
'#End If

'' MACRO: SS_ALLOCA
'' ----------------
''      Some implementations of the Standard C Library have a non-standard
''      function known as alloca().  This functions allows one to allocate a
''      variable amount of memory on the stack.  It is needed to implement
''      the ASCII/MBCS conversion macros.
''
''      I wanted to find some way to determine automatically if alloca() is
''		available on this platform via compiler flags but that is asking for
''		trouble.  The crude test presented here will likely need fixing on
''		other platforms.  Therefore I'll leave it up to you to fiddle with
''		this test to determine if it exists.  Just make sure SS_ALLOCA is or
''		is not defined as appropriate and you control this feature.

'#If _MSC_VER AndAlso (Not SS_ANSI) Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_ALLOCA
'	#Const SS_ALLOCA = True
'#End If


'' MACRO: SS_MBCS
'' --------------
''		Setting this macro means you are using MBCS characters.  In MSVC builds,
''		this macro gets set automatically by detection of the preprocessor flag
''		_MBCS.  For other platforms you may set it manually if you wish.  The
''		only effect it currently has is to cause the allocation of more space
''		for wchar_t --> char conversions.
''		Note that MBCS does not mean UNICODE.
''
''	#define SS_MBCS
''

'#If _MBCS Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SS_MBCS
'	#Const SS_MBCS = True
'#End If


'' MACRO SS_NO_LOCALE
'' ------------------
'' If your implementation of the Standard C++ Library lacks the <locale> header,
'' you can #define this macro to make your code build properly.  Note that this
'' is some of my newest code and frankly I'm not very sure of it, though it does
'' pass my unit tests.

'' #define SS_NO_LOCALE


'' Compiler Error regarding _UNICODE and UNICODE
'' -----------------------------------------------
'' Microsoft header files are screwy.  Sometimes they depend on a preprocessor 
'' flag named "_UNICODE".  Other times they check "UNICODE" (note the lack of
'' leading underscore in the second version".  In several places, they silently
'' "synchronize" these two flags this by defining one of the other was defined. 
'' In older version of this header, I used to try to do the same thing. 
''
'' However experience has taught me that this is a bad idea.  You get weird
'' compiler errors that seem to indicate things like LPWSTR and LPTSTR not being
'' equivalent in UNICODE builds, stuff like that (when they MUST be in a proper
'' UNICODE  build).  You end up scratching your head and saying, "But that HAS
'' to compile!".
''
'' So what should you do if you get this error?
''
'' Make sure that both macros (_UNICODE and UNICODE) are defined before this
'' file is included.  You can do that by either
''
''		a) defining both yourself before any files get included
''		b) including the proper MS headers in the proper order
''		c) including this file before any other file, uncommenting
''		   the #defines below, and commenting out the #errors
''
''	Personally I recommend solution a) but it's your call.

'#If _MSC_VER Then
'	#If _UNICODE AndAlso (Not UNICODE) Then
'		#error UNICODE but ! UNICODE
'	'	#define UNICODE  // no longer silently fix this
'	#End If
'	#If UNICODE AndAlso (Not _UNICODE) Then
'		#error Warning, UNICODE but ! _UNICODE
'	'	#define _UNICODE  // no longer silently fix this
'	#End If
'#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class Type>


'' -----------------------------------------------------------------------------
'' Functional objects for changing case.  They also let you pass locales
'' -----------------------------------------------------------------------------

'#If SS_NO_LOCALE Then
'	Public Class SSToUpper (Of CT)
'		Implements std.unary_function(Of CT, CT)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline CT operator ()(const CT& t) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'		Public Shared Operator ()(ByVal t As CT) As CT
'			Return GlobalMembersScraperParser.sstoupper(t)
'		End Operator
'	End Class
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'	Public Class SSToLower (Of CT)
'		Implements std.unary_function(Of CT, CT)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline CT operator ()(const CT& t) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'		Public Shared Operator ()(ByVal t As CT) As CT
'			Return GlobalMembersScraperParser.sstolower(t)
'		End Operator
'	End Class
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'#Else
'	Public Class SSToUpper (Of CT)
'		Implements std.binary_function(Of CT, std.locale, CT)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline CT operator ()(const CT& t, const std::locale& loc) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'		Public Shared Operator ()(ByVal t As CT, ByVal loc As std.locale) As CT
'			Return GlobalMembersScraperParser.sstoupper(Of CT)(t, loc)
'		End Operator
'	End Class
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>
'	Public Class SSToLower (Of CT)
'		Implements std.binary_function(Of CT, std.locale, CT)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline CT operator ()(const CT& t, const std::locale& loc) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'		Public Shared Operator ()(ByVal t As CT, ByVal loc As std.locale) As CT
'			Return GlobalMembersScraperParser.sstolower(Of CT)(t, loc)
'		End Operator
'	End Class
'#End If
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'' This struct is used for TrimRight() and TrimLeft() function implementations.
''template<typename CT>
''struct NotSpace : public std::unary_function<CT, bool>
''{
''	const std::locale& loc;
''	inline NotSpace(const std::locale& locArg) : loc(locArg) {}
''	inline bool operator() (CT t) { return !std::isspace(t, loc); }
''};
'Public Class NotSpace (Of CT)
'	Implements std.unary_function(Of CT, Boolean)
'	' DINKUMWARE BUG:
'	' Note -- using std::isspace in a COM DLL gives us access violations
'	' because it causes the dynamic addition of a function to be called
'	' when the library shuts down.  Unfortunately the list is maintained
'	' in DLL memory but the function is in static memory.  So the COM DLL
'	' goes away along with the function that was supposed to be called,
'	' and then later when the DLL CRT shuts down it unloads the list and
'	' tries to call the long-gone function.
'	' This is DinkumWare's implementation problem.  If you encounter this
'	' problem, you may replace the calls here with good old isspace() and
'	' iswspace() from the CRT unless they specify SS_ANSI


'#If SS_NO_LOCALE Then
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Boolean operator ()(CT t) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal t As CT) As Boolean
'		Return Not GlobalMembersScraperParser.ssisspace(t)
'	End Operator

'#Else
'	Public ReadOnly loc As GlobalMembersScraperParser.std.locale
'	Public Sub New(Optional ByVal locArg As std.locale = std.locale())
'		loc = locArg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Boolean operator ()(CT t) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal t As CT) As Boolean
'		Return Not GlobalMembersScraperParser.std.isspace(t, loc)
'	End Operator
'#End If
'End Class
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename ARG>




''			Now we can define the template (finally!)
'' =============================================================================
'' TEMPLATE: CStdStr
''		template<typename CT> class CStdStr : public std::basic_string<CT>
''
'' REMARKS:
''		This template derives from basic_string<CT> and adds some MFC CString-
''		like functionality
''
''		Basically, this is my attempt to make Standard C++ library strings as
''		easy to use as the MFC CString class.
''
''		Note that although this is a template, it makes the assumption that the
''		template argument (CT, the character type) is either char or wchar_t.  
'' =============================================================================

''#define CStdStr _SS	// avoid compiler warning 4786

''    template<typename ARG> ARG& FmtArg(ARG& arg)  { return arg; }
''    PCSTR  FmtArg(const std::string& arg)  { return arg.c_str(); }
''    PCWSTR FmtArg(const std::wstring& arg) { return arg.c_str(); }

'Public Class FmtArg (Of ARG)
'	Public Sub New(ByVal arg As ARG)
'		a_ = arg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const ARG& operator ()() const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()() As ARG
'		Return a_
'	End Operator
'	Public ReadOnly a_ As ARG
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: FmtArg& operator =(const FmtArg&)
'	Private Function CopyFrom(ByVal UnnamedParameter1 As FmtArg) As FmtArg
'		Return Me
'	End Function
'End Class
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<typename CT>

'Public Class CStdStr (Of CT)
'	Inherits std.basic_string(Of CT)
'	' Typedefs for shorter names.  Using these names also appears to help
'	' us avoid some ambiguities that otherwise arise on some platforms

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define MYBASE std::basic_string<CT>
'	#Const MYBASE = True
'	'typedef typename std::basic_string<CT>		MYBASE;	 // my base class

'	' shorthand conversion from PCTSTR to string resource ID

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define SSRES(pctstr) LOWORD(reinterpret_cast<unsigned long>(pctstr))
'	#Const SSRES = True
'	Public Function TryLoad(ByVal pT As IntPtr) As Boolean
'		Dim bLoaded As Boolean = False

'#If SS_WIN32 AndAlso (Not SS_ANSI) Then
'		If (pT IsNot Nothing) AndAlso (False) Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'			Dim nId As UInteger = LOWORD(reinterpret_cast<UInteger>(pT))
'			If (Not LoadString(nId)) Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'				(_T("Can't load string %u" & Constants.vbLf), LOWORD(reinterpret_cast<UInteger>(pT)))
'			End If
'			bLoaded = True
'		End If
'#End If

'		Return bLoaded
'	End Function


'	' CStdStr inline constructors
'	Public Sub New()
'	End Sub

'	Public Sub New(ByVal str As CStdStr(Of CT))
'		GlobalMembersScraperParser.std.basic_string = Of CT
'	End Sub

'	Public Sub New(ByVal str As String)
'		GlobalMembersScraperParser.ssasn(Me, (str))
'	End Sub

'	Public Sub New(ByVal str As String)
'		GlobalMembersScraperParser.ssasn(Me, (str))
'	End Sub

'	Public Sub New(ByVal pT As typename(Of CT), ByVal n As typename(Of CT))
'		GlobalMembersScraperParser.std.basic_string = Of CT
'	End Sub

'#If SS_UNSIGNED Then
'	Public Sub New(ByVal pU As UInteger)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'		Me = reinterpret_cast<const GlobalMembersScraperParser.std.codecvt(Of )(pU)
'	End Sub
'#End If

'	Public Sub New(ByVal pA As std.codecvt)
'	#If SS_ANSI Then
'		Me = pA
'	#Else
'		If (Not TryLoad(pA)) Then
'			Me = pA
'		End If
'	#End If
'	End Sub

'	Public Sub New(ByVal pW As std.codecvt)
'	#If SS_ANSI Then
'		Me = pW
'	#Else
'		If (Not TryLoad(pW)) Then
'			Me = pW
'		End If
'	#End If
'	End Sub

'	Public Sub New(ByVal first As typename(Of CT), ByVal last As typename(Of CT))
'		GlobalMembersScraperParser.std.basic_string = Of CT
'	End Sub

'	Public Sub New(ByVal nSize As typename(Of CT), ByVal ch As typename(Of CT), Optional ByVal al As typename(Of CT) = typename std.basic_string(Of CT).allocator_type())
'		GlobalMembersScraperParser.std.basic_string = Of CT
'	End Sub

'	#If SS_INC_COMDEF Then
'		Public Sub New(ByVal bstr As _bstr_t)
'			If bstr.length() > 0 Then
'				Me.append(CType(bstr, typename GlobalMembersScraperParser.std.basic_string(Of CT).const_pointer), bstr.length())
'			End If
'		End Sub
'	#End If

'	' CStdStr inline assignment operators -- the ssasn function now takes care
'	' of fixing  the MSVC assignment bug (see knowledge base article Q172398).
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const CStdStr(Of CT)& str)
'	Public Function CopyFrom(ByVal str As CStdStr(Of CT)) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssasn(Me, str)
'		Return Me
'	End Function

''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const String& str)
'	Public Function CopyFrom(ByVal str As String) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssasn(Me, str)
'		Return Me
'	End Function

''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const String& str)
'	Public Function CopyFrom(ByVal str As String) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssasn(Me, str)
'		Return Me
'	End Function

''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const std::codecvt<* pA)
'	Public Function CopyFrom(ByVal pA As std.codecvt) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssasn(Me, pA)
'		Return Me
'	End Function

''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const std::codecvt<* pW)
'	Public Function CopyFrom(ByVal pW As std.codecvt) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssasn(Me, pW)
'		Return Me
'	End Function

'#If SS_UNSIGNED Then
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const UInteger std::codecvt<* pU)
'	Public Function CopyFrom(ByVal pU As UInteger) As CStdStr(Of CT)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'		GlobalMembersScraperParser.ssasn(Me, reinterpret_cast<const GlobalMembersScraperParser.std.codecvt(Of )(pU))
'		Return Me
'	End Function
'#End If

''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(CT t)
'	Public Function CopyFrom(ByVal t As CT) As CStdStr(Of CT)
'		x( Me)
'		Me.assign(1, t)
'		Return Me
'	End Function

'	#If SS_INC_COMDEF Then
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: CStdStr(Of CT)& operator =(const _bstr_t& bstr)
'		Public Function CopyFrom(ByVal bstr As _bstr_t) As CStdStr(Of CT)
'			If bstr.length() > 0 Then
'				Me.assign(CType(bstr, typename GlobalMembersScraperParser.std.basic_string(Of CT).const_pointer), bstr.length())
'				Return Me
'			Else
'				Me.erase()
'				Return Me
'			End If
'		End Function
'	#End If


'	' Overloads  also needed to fix the MSVC assignment bug (KB: Q172398)
'	'  *** Thanks to Pete The Plumber for catching this one ***
'	' They also are compiled if you have explicitly turned off refcounting

'	#If (_MSC_VER AndAlso (_MSC_VER < 1200)) OrElse SS_NO_REFCOUNT Then
'		Public Function assign(ByVal str As CStdStr(Of CT)) As CStdStr(Of CT)
'			x( Me)
'			GlobalMembersScraperParser.sscpy(GetBuffer(str.Length+1), (str))
'			Me.ReleaseBuffer(str.Length)
'			Return Me
'		End Function

'		Public Function assign(ByVal str As CStdStr(Of CT), ByVal nStart As typename(Of CT), ByVal nChars As typename(Of CT)) As CStdStr(Of CT)
'			' This overload of basic_string::assign is supposed to assign up to
'			' <nChars> or the NULL terminator, whichever comes first.  Since we
'			' are about to call a less forgiving overload (in which <nChars>
'			' must be a valid length), we must adjust the length here to a safe
'			' value.  Thanks to Ullrich Pollï¿½hne for catching this bug

'			nChars = GlobalMembersScraperParser.SSMIN(nChars, str.Length - nStart)
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'			Dim strTemp As New GlobalMembersScraperParser.CStdStr(Of CT)(str.c_str()+nStart, nChars)
'			x( Me)
'			Me.assign(strTemp)
'			Return Me
'		End Function

'		Public Function assign(ByVal str As std.basic_string(Of CT)) As CStdStr(Of CT)
'			GlobalMembersScraperParser.ssasn(Me, str)
'			Return Me
'		End Function

'		Public Function assign(ByVal str As std.basic_string(Of CT), ByVal nStart As typename(Of CT), ByVal nChars As typename(Of CT)) As CStdStr(Of CT)
'			' This overload of basic_string::assign is supposed to assign up to
'			' <nChars> or the NULL terminator, whichever comes first.  Since we
'			' are about to call a less forgiving overload (in which <nChars>
'			' must be a valid length), we must adjust the length here to a safe
'			' value. Thanks to Ullrich Pollï¿½hne for catching this bug

'			nChars = GlobalMembersScraperParser.SSMIN(nChars, str.Length - nStart)

'			' Watch out for assignment to self

'			If Me Is str Then
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'				Dim strTemp As New GlobalMembersScraperParser.CStdStr(Of CT)(str.c_str() + nStart, nChars)
'				CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).assign(strTemp)
'			Else
'				x( Me)
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'				CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).assign(str.c_str()+nStart, nChars)
'			End If
'			Return Me
'		End Function

'		Public Function assign(ByVal pC As CT, ByVal nChars As typename(Of CT)) As CStdStr(Of CT)
'			' Q172398 only fix -- erase before assigning, but not if we're
'			' assigning from our own buffer

'	#If _MSC_VER AndAlso (_MSC_VER < 1200) Then
'			If (Not Me.empty()) AndAlso (pC < Me.data() OrElse pC > Me.data() + Me.capacity()) Then
'				Me.erase()
'			End If
'	#End If
'			x( Me)
'			CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).assign(pC, nChars)
'			Return Me
'		End Function

'		Public Function assign(ByVal nChars As typename(Of CT), ByVal val As typename(Of CT)) As CStdStr(Of CT)
'			x( Me)
'			CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).assign(nChars, val)
'			Return Me
'		End Function

'		Public Function assign(ByVal pT As CT) As CStdStr(Of CT)
'			Return Me.assign(pT, GlobalMembersScraperParser.std.basic_string(Of CT).traits_type.length(pT))
'		End Function

'		Public Function assign(ByVal iterFirst As typename(Of CT), ByVal iterLast As typename(Of CT)) As CStdStr(Of CT)
'	#If _MSC_VER AndAlso (_MSC_VER < 1200) Then
'			' Q172398 fix.  don't call erase() if we're assigning from ourself
'			If iterFirst < Me.begin() OrElse iterFirst > Me.begin() + Me.size() Then
'				Me.erase()
'			End If
'	#End If
'			Me.replace(Me.begin(), Me.end(), iterFirst, iterLast)
'			Return Me
'		End Function
'	#End If


'	' -------------------------------------------------------------------------
'	' CStdStr inline concatenation.
'	' -------------------------------------------------------------------------
''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal str As CStdStr(Of CT)) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssadd(Me, str)
'		Return Me
'	End Operator

''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal str As String) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssadd(Me, str)
'		Return Me
'	End Operator

''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal str As String) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssadd(Me, str)
'		Return Me
'	End Operator

''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal pA As std.codecvt) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssadd(Me, pA)
'		Return Me
'	End Operator

''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal pW As std.codecvt) As CStdStr(Of CT)
'		GlobalMembersScraperParser.ssadd(Me, pW)
'		Return Me
'	End Operator

''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'	 Public Shared Operator +=(ByVal t As CT) As CStdStr(Of CT)
'		Me.append(1, t)
'		Return Me
'	End Operator
'	#If SS_INC_COMDEF Then
''C++ TO VB CONVERTER TODO TASK: The += operator cannot be overloaded in VB:
'		 Public Shared Operator +=(ByVal bstr As _bstr_t) As CStdStr(Of CT)
'			Return Me.operator +=(CType(bstr, typename GlobalMembersScraperParser.std.basic_string(Of CT).const_pointer))
'		End Operator
'	#End If


'	' -------------------------------------------------------------------------
'	' Case changing functions
'	' -------------------------------------------------------------------------

'	Public Function ToUpper(Optional ByVal loc As std.locale = std.locale()) As CStdStr(Of CT)
'		' Note -- if there are any MBCS character sets in which the lowercase
'		' form a character takes up a different number of bytes than the
'		' uppercase form, this would probably not work...

'#If SS_NO_LOCALE Then
'		GlobalMembersScraperParser.std.transform(Me.begin(), Me.end(), Me.begin(),New SSToUpper(Of CT)())
'#Else
'		GlobalMembersScraperParser.std.transform(Me.begin(), Me.end(), Me.begin(),GlobalMembersScraperParser.std.bind2nd(New SSToUpper(Of CT)(), loc))
'#End If

'		' ...but if it were, this would probably work better.  Also, this way
'		' seems to be a bit faster when anything other then the "C" locale is
'		' used...

''		if ( !empty() )
''		{
''			ssupr(this->GetBuf(), this->size(), loc);
''			this->RelBuf();
''		}

'		Return Me
'	End Function

'	Public Function ToLower(Optional ByVal loc As std.locale = std.locale()) As CStdStr(Of CT)
'		' Note -- if there are any MBCS character sets in which the lowercase
'		' form a character takes up a different number of bytes than the
'		' uppercase form, this would probably not work...

'#If SS_NO_LOCALE Then
'		GlobalMembersScraperParser.std.transform(Me.begin(), Me.end(), Me.begin(),New SSToLower(Of CT)())
'#Else
'		GlobalMembersScraperParser.std.transform(Me.begin(), Me.end(), Me.begin(),GlobalMembersScraperParser.std.bind2nd(New SSToLower(Of CT)(), loc))
'#End If

'		' ...but if it were, this would probably work better.  Also, this way
'		' seems to be a bit faster when anything other then the "C" locale is
'		' used...

''		if ( !empty() )
''		{
''			sslwr(this->GetBuf(), this->size(), loc);
''			this->RelBuf();
''		}
'		Return Me
'	End Function


'	Public Function Normalize() As CStdStr(Of CT)
'		Return Trim().ToLower()
'	End Function


'	' -------------------------------------------------------------------------
'	' CStdStr -- Direct access to character buffer.  In the MS' implementation,
'	' the at() function that we use here also calls _Freeze() providing us some
'	' protection from multithreading problems associated with ref-counting.
'	' In VC 7 and later, of course, the ref-counting stuff is gone.
'	' -------------------------------------------------------------------------

'	Public Function GetBuf(Optional ByVal nMinLen As Integer = -1) As CT
'		If CInt(Fix(Me.size())) < nMinLen Then
'			Me.resize(CType(nMinLen, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End If

''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
'		Return If(Me.empty(), const_cast<CT*>(Me.data()), (Me.at(0)))
'	End Function

'	Public Function SetBuf(ByVal nLen As Integer) As CT
'		nLen = (If(nLen > 0, nLen, 0))
'		If Me.capacity() < 1 AndAlso nLen = 0 Then
'			Me.resize(1)
'		End If

'		Me.resize(CType(nLen, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'const_cast' in VB:
'		Return const_cast<CT*>(Me.data())
'	End Function
'	Public Sub RelBuf(Optional ByVal nNewLen As Integer = -1)
'		Me.resize(CType(If(nNewLen > -1, nNewLen, GlobalMembersScraperParser.sslen(Me.c_str())), typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'	End Sub

'	Public Sub BufferRel() ' backwards compatability
'		RelBuf()
'	End Sub
'	Public Function Buffer() As CT ' backwards compatability
'		Return GetBuf()
'	End Function
'	Public Function BufferSet(ByVal nLen As Integer) As CT ' backwards compatability
'		Return SetBuf(nLen)
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Boolean Equals(const CT* pT, Boolean bUseCase=False) const
'	Public Function Equals(ByVal pT As CT, Optional ByVal bUseCase As Boolean = False) As Boolean
'		Return 0 = (If(bUseCase, Me.compare(pT), GlobalMembersScraperParser.ssicmp(Me.c_str(), pT)))
'	End Function

'	' -------------------------------------------------------------------------
'	' FUNCTION:  CStdStr::Load
'	' REMARKS:
'	'		Loads string from resource specified by nID
'	'
'	' PARAMETERS:
'	'		nID - resource Identifier.  Purely a Win32 thing in this case
'	'
'	' RETURN VALUE:
'	'		true if successful, false otherwise
'	' -------------------------------------------------------------------------


'#If Not SS_ANSI Then
'	Public Function Load(ByVal nId As UInteger, Optional ByVal hModule As IntPtr = Nothing) As Boolean
'		Dim bLoaded As Boolean = False ' set to true of we succeed.


'	#If _MFC_VER Then
'		' If they gave a resource handle, use it.  Note - this is archaic
'		' and not really what I would recommend.  But then again, in MFC
'		' land, you ought to be using CString for resources anyway since
'		' it walks the resource chain for you.

'		Dim hModuleOld As IntPtr = Nothing

'		If Nothing IsNot hModule Then
'			hModuleOld = AfxGetResourceHandle()
'			AfxSetResourceHandle(hModule)
'		End If

'		' ...load the string

'		Dim strRes As GlobalMembersScraperParser.String
'		bLoaded = False <> strRes.LoadString(nId)

'		' ...and if we set the resource handle, restore it.

'		If Nothing IsNot hModuleOld Then
'			AfxSetResourceHandle(hModule)
'		End If

'		If bLoaded Then
'			Me = strRes
'		End If


'	#Else
'		' Get the resource name and module handle

'		If Nothing Is hModule Then
'			hModule = GetResourceHandle()
'		End If

'		Dim szName As GlobalMembersScraperParser.String = MAKEINTRESOURCE((nId>>4)+1) ' lifted
'		Dim dwSize As UInteger = 0

'		' No sense continuing if we can't find the resource

'		Dim hrsrc As IntPtr =FindResource(hModule, szName, RT_STRING)

'		If Nothing Is hrsrc Then
'			(_T("Cannot find resource %d: 0x%X"), nId,GetLastError())
''C++ TO VB CONVERTER TODO TASK: Assignments within expressions are not supported in VB.NET
''ORIGINAL LINE: else if (0 == (dwSize =::SizeofResource(hModule, hrsrc) / sizeof(CT)))
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		ElseIf 0 = (dwSize =SizeofResource(hModule, hrsrc) / sizeof(CT)) Then
'			(_T("Cant get size of resource %d 0x%X" & Constants.vbLf),nId,GetLastError())
'		Else
'			bLoaded = False <> GlobalMembersScraperParser.ssload(hModule, nId, GetBuf(dwSize), dwSize)
'			ReleaseBuffer()
'		End If

'	#End If ' #ifdef _MFC_VER

'		If (Not bLoaded) Then
'			(_T("String not loaded 0x%X" & Constants.vbLf),GetLastError())
'		End If

'		Return bLoaded
'	End Function

'#End If ' #ifdef SS_ANSI

'	' -------------------------------------------------------------------------
'	' FUNCTION:  CStdStr::Format
'	'		void _cdecl Formst(CStdStringA& PCSTR szFormat, ...)
'	'		void _cdecl Format(PCSTR szFormat);
'	'           
'	' DESCRIPTION:
'	'		This function does sprintf/wsprintf style formatting on CStdStringA
'	'		objects.  It looks a lot like MFC's CString::Format.  Some people
'	'		might even call this identical.  Fortunately, these people are now
'	'		dead... heh heh.
'	'
'	' PARAMETERS: 
'	'		nId - ID of string resource holding the format string
'	'		szFormat - a PCSTR holding the format specifiers
'	'		argList - a va_list holding the arguments for the format specifiers.
'	'
'	' RETURN VALUE:  None.
'	' -------------------------------------------------------------------------
'	' formatting (using wsprintf style formatting)

'	' If they want a Format() function that safely handles string objects
'	' without casting


'#If SS_SAFE_FORMAT Then
'	' Question:  Joe, you wacky coder you, why do you have so many overloads
'	'      of the Format() function
'	' Answer:  One reason only - CString compatability.  In short, by making
'	'      the Format() function a template this way, I can do strong typing
'	'      and allow people to pass CStdString arguments as fillers for
'	'      "%s" format specifiers without crashing their program!  The downside
'	'      is that I need to overload on the number of arguments.   If you are
'	'      passing more arguments than I have listed below in any of my
'	'      overloads, just add another one.
'	'
'	'      Yes, yes, this is really ugly.  In essence what I am doing here is
'	'      protecting people from a bad (and incorrect) programming practice
'	'      that they should not be doing anyway.  I am protecting them from
'	'      themselves.  Why am I doing this?  Well, if you had any idea the
'	'      number of times I've been emailed by people about this
'	'      "incompatability" in my code, you wouldn't ask.

'	Public Sub Fmt(ByVal szFmt As CT, ParamArray ByVal LegacyParamArray() As Object)
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, szFmt)
'		FormatV(szFmt, argList)
''		va_end(argList)
'	End Sub


'#If Not SS_ANSI Then
'	Public Sub Format(ByVal nId As UInteger)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Me.swap(strFmt)
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1>
'	Public Sub Format(Of A1)(ByVal nId As UInteger, ByVal v As A1)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2>
'	Public Sub Format(Of A1, A2)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'		   Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3>
'	Public Sub Format(Of A1, A2, A3)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4>
'	Public Sub Format(Of A1, A2, A3, A4)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5>
'	Public Sub Format(Of A1, A2, A3, A4, A5)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(),New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(),New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'		   Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(),New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(), New FmtArg(Of A13)(v13)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(), New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15, class A16>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15, ByVal v16 As A16)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)(), New FmtArg(Of A16)(v16)())
'		End If
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15, class A16, class A17>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17)(ByVal nId As UInteger, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15, ByVal v16 As A16, ByVal v17 As A17)
'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			Fmt(strFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)(),New FmtArg(Of A16)(v16)(),New FmtArg(Of A17)(v17)())
'		End If
'	End Sub

'#End If ' #ifndef SS_ANSI

'	' ...now the other overload of Format: the one that takes a string literal

'	Public Sub Format(ByVal szFmt As CT)
'		Me = szFmt
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1>
'	Public Sub Format(Of A1)(ByVal szFmt As CT, ByVal v As A1)
'		Fmt(szFmt, New FmtArg(Of A1)(v)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2>
'	Public Sub Format(Of A1, A2)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3>
'	Public Sub Format(Of A1, A2, A3)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4>
'	Public Sub Format(Of A1, A2, A3, A4)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5>
'	Public Sub Format(Of A1, A2, A3, A4, A5)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(),New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(), New FmtArg(Of A13)(v13)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(), New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15, class A16>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15, ByVal v16 As A16)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)(), New FmtArg(Of A16)(v16)())
'	End Sub
''C++ TO VB CONVERTER TODO TASK: The original C++ template specifier was replaced with a VB generic specifier, which may not produce the same behavior:
''ORIGINAL LINE: template<class A1, class A2, class A3, class A4, class A5, class A6, class A7, class A8, class A9, class A10, class A11, class A12, class A13, class A14, class A15, class A16, class A17>
'	Public Sub Format(Of A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17)(ByVal szFmt As CT, ByVal v1 As A1, ByVal v2 As A2, ByVal v3 As A3, ByVal v4 As A4, ByVal v5 As A5, ByVal v6 As A6, ByVal v7 As A7, ByVal v8 As A8, ByVal v9 As A9, ByVal v10 As A10, ByVal v11 As A11, ByVal v12 As A12, ByVal v13 As A13, ByVal v14 As A14, ByVal v15 As A15, ByVal v16 As A16, ByVal v17 As A17)
'		Fmt(szFmt, New FmtArg(Of A1)(v1)(), New FmtArg(Of A2)(v2)(), New FmtArg(Of A3)(v3)(), New FmtArg(Of A4)(v4)(), New FmtArg(Of A5)(v5)(), New FmtArg(Of A6)(v6)(), New FmtArg(Of A7)(v7)(), New FmtArg(Of A8)(v8)(), New FmtArg(Of A9)(v9)(), New FmtArg(Of A10)(v10)(),New FmtArg(Of A11)(v11)(), New FmtArg(Of A12)(v12)(),New FmtArg(Of A13)(v13)(),New FmtArg(Of A14)(v14)(), New FmtArg(Of A15)(v15)(),New FmtArg(Of A16)(v16)(),New FmtArg(Of A17)(v17)())
'	End Sub




'#Else
'#If Not SS_ANSI Then
'	Public Sub Format(ByVal nId As UInteger, ParamArray ByVal LegacyParamArray() As Object)
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, nId)

'		Dim strFmt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		If strFmt.Load(nId) Then
'			FormatV(strFmt, argList)
'		End If

''		va_end(argList)
'	End Sub

'#End If ' #ifdef SS_ANSI

'	Public Sub Format(ByVal szFmt As CT, ParamArray ByVal LegacyParamArray() As Object)
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, szFmt)
'		FormatV(szFmt, argList)
''		va_end(argList)
'	End Sub

'#End If ' #ifdef SS_SAFE_FORMAT

'	Public Sub AppendFormat(ByVal szFmt As CT, ParamArray ByVal LegacyParamArray() As Object)
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, szFmt)
'		AppendFormatV(szFmt, argList)
''		va_end(argList)
'	End Sub


'	#Const MAX_FMT_TRIES = True
'	#Const FMT_BLOCK_SIZE = True
'	#Const BUFSIZE_1ST = True
'	#Const BUFSIZE_2ND = True
'	#Const STD_BUF_SIZE = True
'	' an efficient way to add formatted characters to the string.  You may only
'	' add up to STD_BUF_SIZE characters at a time, though
'	Public Sub AppendFormatV(ByVal szFmt As CT, ByVal argList As va_list)
'		Dim szBuf(DefineConstantsScraperParser.STD_BUF_SIZE - 1) As CT
'		Dim nLen As Integer = GlobalMembersScraperParser.ssnprintf(szBuf, DefineConstantsScraperParser.STD_BUF_SIZE-1, szFmt, argList)

'		If 0 < nLen Then
'			Me.append(szBuf, nLen)
'		End If
'	End Sub

'	' -------------------------------------------------------------------------
'	' FUNCTION:  FormatV
'	'		void FormatV(PCSTR szFormat, va_list, argList);
'	'           
'	' DESCRIPTION:
'	'		This function formats the string with sprintf style format-specs. 
'	'		It makes a general guess at required buffer size and then tries
'	'		successively larger buffers until it finds one big enough or a
'	'		threshold (MAX_FMT_TRIES) is exceeded.
'	'
'	' PARAMETERS: 
'	'		szFormat - a PCSTR holding the format of the output
'	'		argList - a Microsoft specific va_list for variable argument lists
'	'
'	' RETURN VALUE: 
'	' -------------------------------------------------------------------------

'	Public Sub FormatV(ByVal szFormat As CT, ByVal argList As va_list)
'	#If SS_ANSI Then
'		Dim str As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		Dim nLen As Integer = GlobalMembersScraperParser.sslen(szFormat) + DefineConstantsScraperParser.STD_BUF_SIZE
'		GlobalMembersScraperParser.ssvsprintf(str.GetBuffer(nLen), nLen-1, szFormat, argList)
'		str.ReleaseBuffer()
'		Me = str


'	#Else
'		Dim pBuf() As CT = Nothing
'		Dim nChars As Integer = 1
'		Dim nUsed As Integer = 0
'		Dim nActual As size_t = 0
'		Dim nTry As Integer = 0

'		Do
'			' Grow more than linearly (e.g. 512, 1536, 3072, etc)

'			nChars += ((nTry+1) * DefineConstantsScraperParser.FMT_BLOCK_SIZE)
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'			pBuf = reinterpret_cast<CT*>(_alloca(sizeof(CT)*nChars))
'			nUsed = GlobalMembersScraperParser.ssnprintf(pBuf, nChars-1, szFormat, argList)

'			' Ensure proper NULL termination.

'			nActual = If(nUsed = -1, nChars-1, GlobalMembersScraperParser.SSMIN(nUsed, nChars-1))
'			pBuf(nActual)= ControlChars.NullChar


'		Loop While nUsed < 0 AndAlso nTry < DefineConstantsScraperParser.MAX_FMT_TRIES
'		nTry += 1

'		' assign whatever we managed to format

'		Me.assign(pBuf, nActual)

'	#End If
'	End Sub

'	' -------------------------------------------------------------------------
'	' CString Facade Functions:
'	'
'	' The following methods are intended to allow you to use this class as a
'	' near drop-in replacement for CString.
'	' -------------------------------------------------------------------------
'	#If SS_WIN32 Then
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: String AllocSysString() const
'		Public Function AllocSysString() As String
'			GlobalMembersScraperParser.std.basic_string<GlobalMembersScraperParser.std.codecvt(Of ) os
'			GlobalMembersScraperParser.ssasn(os, Me)
'			Return SysAllocString(os.c_str())
'		End Function
'	#End If

'#If Not SS_NO_LOCALE Then
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Collate(typename std::basic_string(Of CT)::const_pointer szThat) const
'	Public Function Collate(ByVal szThat As typename(Of CT)) As Integer
'		Return GlobalMembersScraperParser.sscoll(Me.c_str(), Me.length(), szThat, GlobalMembersScraperParser.sslen(szThat))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer CollateNoCase(typename std::basic_string(Of CT)::const_pointer szThat) const
'	Public Function CollateNoCase(ByVal szThat As typename(Of CT)) As Integer
'		Return GlobalMembersScraperParser.ssicoll(Me.c_str(), Me.length(), szThat, GlobalMembersScraperParser.sslen(szThat))
'	End Function
'#End If
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Compare(typename std::basic_string(Of CT)::const_pointer szThat) const
'	Public Function Compare(ByVal szThat As typename(Of CT)) As Integer
'		Return Me.compare(szThat)
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer CompareNoCase(typename std::basic_string(Of CT)::const_pointer szThat) const
'	Public Function CompareNoCase(ByVal szThat As typename(Of CT)) As Integer
'		Return GlobalMembersScraperParser.ssicmp(Me.c_str(), szThat)
'	End Function

'	Public Function Delete(ByVal nIdx As Integer, Optional ByVal nCount As Integer = 1) As Integer
'		If nIdx < 0 Then
'			nIdx = 0
'		End If

'		If nIdx < Me.GetLength() Then
'			Me.erase(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type), CType(nCount, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End If

'		Return GetLength()
'	End Function

'	Public Sub Empty()
'		Me.erase()
'	End Sub

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Find(CT ch) const
'	Public Function Find(ByVal ch As CT) As Integer
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_first_of(ch)
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Find(typename std::basic_string(Of CT)::const_pointer szSub) const
'	Public Function Find(ByVal szSub As typename(Of CT)) As Integer
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find(szSub)
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Find(CT ch, Integer nStart) const
'	Public Function Find(ByVal ch As CT, ByVal nStart As Integer) As Integer
'		' CString::Find docs say add 1 to nStart when it's not zero
'		' CString::Find code doesn't do that however.  We'll stick
'		' with what the code does

'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_first_of(ch, CType(nStart, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer Find(typename std::basic_string(Of CT)::const_pointer szSub, Integer nStart) const
'	Public Function Find(ByVal szSub As typename(Of CT), ByVal nStart As Integer) As Integer
'		' CString::Find docs say add 1 to nStart when it's not zero
'		' CString::Find code doesn't do that however.  We'll stick
'		' with what the code does

'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find(szSub, CType(nStart, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer FindOneOf(typename std::basic_string(Of CT)::const_pointer szCharSet) const
'	Public Function FindOneOf(ByVal szCharSet As typename(Of CT)) As Integer
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_first_of(szCharSet)
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

'#If Not SS_ANSI Then
''C++ TO VB CONVERTER WARNING: Throw clauses are not available in VB:
''ORIGINAL LINE: void FormatMessage(typename std::basic_string(Of CT)::const_pointer szFormat,...) throw(std::exception)
'	Public Sub FormatMessage(ByVal szFormat As typename(Of CT), ParamArray ByVal LegacyParamArray() As Object)
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, szFormat)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).pointer szTemp
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'		If GlobalMembersScraperParser.ssfmtmsg(FORMAT_MESSAGE_FROM_STRING Or FORMAT_MESSAGE_ALLOCATE_BUFFER, szFormat, 0, 0, reinterpret_cast<typename GlobalMembersScraperParser.std.basic_string(Of CT).pointer>(szTemp), 0, argList) = 0 OrElse szTemp = 0 Then
'			Throw GlobalMembersScraperParser.std.runtime_error("out of memory")
'		End If
'		Me = szTemp
'		LocalFree(szTemp)
''		va_end(argList)
'	End Sub

''C++ TO VB CONVERTER WARNING: Throw clauses are not available in VB:
''ORIGINAL LINE: void FormatMessage(UInteger nFormatId,...) throw(std::exception)
'	Public Sub FormatMessage(ByVal nFormatId As UInteger, ParamArray ByVal LegacyParamArray() As Object)
'		Dim sFormat As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		VERIFY(sFormat.LoadString(nFormatId))
''		Dim argList As va_list
'		Dim ParamCount As Integer = -1
''		va_start(argList, nFormatId)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).pointer szTemp
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'		If GlobalMembersScraperParser.ssfmtmsg(FORMAT_MESSAGE_FROM_STRING Or FORMAT_MESSAGE_ALLOCATE_BUFFER, sFormat, 0, 0, reinterpret_cast<typename GlobalMembersScraperParser.std.basic_string(Of CT).pointer>(szTemp), 0, argList) = 0 OrElse szTemp = 0 Then
'			Throw GlobalMembersScraperParser.std.runtime_error("out of memory")
'		End If
'		Me = szTemp
'		LocalFree(szTemp)
''		va_end(argList)
'	End Sub
'#End If

'	' GetAllocLength -- an MSVC7 function but it costs us nothing to add it.

'	Public Function GetAllocLength() As Integer
'		Return CInt(Fix(Me.capacity()))
'	End Function

'	' -------------------------------------------------------------------------
'	' GetXXXX -- Direct access to character buffer
'	' -------------------------------------------------------------------------
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CT GetAt(Integer nIdx) const
'	Public Function GetAt(ByVal nIdx As Integer) As CT
'		Return Me.at(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'	End Function

'	Public Function GetBuffer(Optional ByVal nMinLen As Integer = -1) As CT
'		Return GetBuf(nMinLen)
'	End Function

'	Public Function GetBufferSetLength(ByVal nLen As Integer) As CT
'		Return BufferSet(nLen)
'	End Function

'	' GetLength() -- MFC docs say this is the # of BYTES but
'	' in truth it is the number of CHARACTERs (chars or wchar_ts)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer GetLength() const
'	Public Function GetLength() As Integer
'		Return CInt(Fix(Me.length()))
'	End Function

'	Public Function Insert(ByVal nIdx As Integer, ByVal ch As CT) As Integer
'		If CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type) > Me.size()-1 Then
'			Me.append(1, ch)
'		Else
'			Me.insert(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type), 1, ch)
'		End If

'		Return GetLength()
'	End Function
'	Public Function Insert(ByVal nIdx As Integer, ByVal sz As typename(Of CT)) As Integer
'		If CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type) >= Me.size() Then
'			Me.append(sz, CType(GlobalMembersScraperParser.sslen(sz), typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		Else
'			Me.insert(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type), sz)
'		End If

'		Return GetLength()
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Boolean IsEmpty() const
'	Public Function IsEmpty() As Boolean
'		Return Me.empty()
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) Left(Integer nCount) const
'	Public Function Left(ByVal nCount As Integer) As CStdStr(Of CT)
'		' Range check the count.

'		nCount = GlobalMembersScraperParser.SSMAX(0, GlobalMembersScraperParser.SSMIN(nCount, CInt(Fix(Me.size()))))
'		Return Me.substr(0, CType(nCount, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'	End Function

'#If Not SS_ANSI Then
'	Public Function LoadString(ByVal nId As UInteger) As Boolean
'		Return Me.Load(nId)
'	End Function
'#End If

'	Public Sub MakeLower()
'		ToLower()
'	End Sub

'	Public Sub MakeReverse()
'		GlobalMembersScraperParser.std.reverse(Me.begin(), Me.end())
'	End Sub

'	Public Sub MakeUpper()
'		ToUpper()
'	End Sub

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) Mid(Integer nFirst) const
'	Public Function Mid(ByVal nFirst As Integer) As CStdStr(Of CT)
'		Return Mid(nFirst, Me.GetLength()-nFirst)
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) Mid(Integer nFirst, Integer nCount) const
'	Public Function Mid(ByVal nFirst As Integer, ByVal nCount As Integer) As CStdStr(Of CT)
'		' CString does range checking here.  Since we're trying to emulate it,
'		' we must check too.

'		If nFirst < 0 Then
'			nFirst = 0
'		End If
'		If nCount < 0 Then
'			nCount = 0
'		End If

'		Dim nSize As Integer = CInt(Fix(Me.size()))

'		If nFirst + nCount > nSize Then
'			nCount = nSize - nFirst
'		End If

'		If nFirst > nSize Then
'			Return GlobalMembersScraperParser.CStdStr(Of CT)()
'		End If

'		Debug.Assert(nFirst >= 0)
'		Debug.Assert(nFirst + nCount <= nSize)

'		Return Me.substr(CType(nFirst, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type), CType(nCount, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'	End Function

'	Public Sub ReleaseBuffer(Optional ByVal nNewLen As Integer = -1)
'		RelBuf(nNewLen)
'	End Sub

'	Public Function Remove(ByVal ch As CT) As Integer
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = 0
'		Dim nRemoved As Integer = 0
'		nIdx=Me.find_first_of(ch)
'		Do While nIdx IsNot GlobalMembersScraperParser.std.basic_string(Of CT).npos
'			Me.erase(nIdx, 1)
'			nRemoved += 1
'			nIdx=Me.find_first_of(ch)
'		Loop
'		Return nRemoved
'	End Function

'	Public Function Replace(ByVal chOld As CT, ByVal chNew As CT) As Integer
'		Dim nReplaced As Integer = 0

'		typename GlobalMembersScraperParser.std.basic_string(Of CT).Enumerator iter =Me.begin()
'		Do While iter IsNot Me.end()
'			If *iter Is chOld Then
'				*iter = chNew
'				nReplaced += 1
'			End If
'			iter += 1
'		Loop

'		Return nReplaced
'	End Function

'	Public Function Replace(ByVal szOld As typename(Of CT), ByVal szNew As typename(Of CT)) As Integer
'		Dim nReplaced As Integer = 0
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = 0
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nOldLen = GlobalMembersScraperParser.sslen(szOld)

'		If 0 <> nOldLen Then
'			' If the replacement string is longer than the one it replaces, this
'			' string is going to have to grow in size,  Figure out how much
'			' and grow it all the way now, rather than incrementally

'			typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nNewLen = GlobalMembersScraperParser.sslen(szNew)
'			If nNewLen > nOldLen Then
'				Dim nFound As Integer = 0
'				nIdx=Me.find(szOld, nIdx)
'				Do While nIdx < Me.length() AndAlso nIdx IsNot GlobalMembersScraperParser.std.basic_string(Of CT).npos
'					nFound += 1
'					nIdx += nOldLen
'					nIdx=Me.find(szOld, nIdx)
'				Loop
'				Me.reserve(Me.size() + nFound * (nNewLen - nOldLen))
'			End If


'			Const ch As New CT(0)
'			typename GlobalMembersScraperParser.std.basic_string(Of CT).const_pointer szRealNew = If(szNew = 0, ch, szNew)
'			nIdx = 0

'			nIdx=Me.find(szOld, nIdx)
'			Do While nIdx < Me.length() AndAlso nIdx IsNot GlobalMembersScraperParser.std.basic_string(Of CT).npos
'				Me.replace(Me.begin()+nIdx, Me.begin()+nIdx+nOldLen, szRealNew)

'				nReplaced += 1
'				nIdx += nNewLen
'				nIdx=Me.find(szOld, nIdx)
'			Loop
'		End If

'		Return nReplaced
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer ReverseFind(CT ch) const
'	Public Function ReverseFind(ByVal ch As CT) As Integer
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_last_of(ch)
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

'	' ReverseFind overload that's not in CString but might be useful
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer ReverseFind(typename std::basic_string(Of CT)::const_pointer szFind, typename std::basic_string(Of CT)::size_type pos=std::basic_string(Of CT)::npos) const
'	Public Function ReverseFind(ByVal szFind As typename(Of CT), Optional ByVal pos As typename(Of CT) = std.basic_string(Of CT).npos) As Integer
'		'yuvalt - this does not compile with g++ since MYTTYPE() is different type 
'		'MYSIZE nIdx	= this->rfind(0 == szFind ? MYTYPE() : szFind, pos);
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.rfind(If(0 = szFind, "", szFind), pos)
'		Return CInt(Fix(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, -1, nIdx)))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) Right(Integer nCount) const
'	Public Function Right(ByVal nCount As Integer) As CStdStr(Of CT)
'		' Range check the count.

'		nCount = GlobalMembersScraperParser.SSMAX(0, GlobalMembersScraperParser.SSMIN(nCount, CInt(Fix(Me.size()))))
'		Return Me.substr(Me.size()-CType(nCount, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'	End Function

'	Public Sub SetAt(ByVal nIndex As Integer, ByVal ch As CT)
'		Debug.Assert(Me.size() > CType(nIndex, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		Me.at(CType(nIndex, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type)) = ch
'	End Sub

'#If Not SS_ANSI Then
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: String SetSysString(String* pbstr) const
'	Public Function SetSysString(ByRef pbstr As String) As String
'		GlobalMembersScraperParser.std.basic_string<GlobalMembersScraperParser.std.codecvt(Of ) os
'		GlobalMembersScraperParser.ssasn(os, Me)
'		If (Not SysReAllocStringLen(pbstr, os.c_str(), os.length())) Then
'			Throw GlobalMembersScraperParser.std.runtime_error("out of memory")
'		End If

'		Debug.Assert( pbstr <> 0)
'		Return pbstr
'	End Function
'#End If

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) SpanExcluding(typename std::basic_string(Of CT)::const_pointer szCharSet) const
'	Public Function SpanExcluding(ByVal szCharSet As typename(Of CT)) As CStdStr(Of CT)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type pos = Me.find_first_of(szCharSet)
'		Return pos = GlobalMembersScraperParser.std.basic_string(Of CT).If(npos, Me, Left(pos))
'	End Function

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: CStdStr(Of CT) SpanIncluding(typename std::basic_string(Of CT)::const_pointer szCharSet) const
'	Public Function SpanIncluding(ByVal szCharSet As typename(Of CT)) As CStdStr(Of CT)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type pos = Me.find_first_not_of(szCharSet)
'		Return pos = GlobalMembersScraperParser.std.basic_string(Of CT).If(npos, Me, Left(pos))
'	End Function


'#If SS_WIN32 AndAlso (Not UNICODE) AndAlso (Not SS_ANSI) Then
'	' CString's OemToAnsi and AnsiToOem functions are available only in
'	' Unicode builds.  However since we're a template we also need a
'	' runtime check of CT and a reinterpret_cast to account for the fact
'	' that CStdStringW gets instantiated even in non-Unicode builds.

'	Public Sub AnsiToOem()
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		If sizeof(CT) = sizeof(GlobalMembersScraperParser.std.codecvt<) AndAlso (Not empty()) Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'			CharToOem(reinterpret_cast<const GlobalMembersScraperParser.std.codecvt(Of )(Me.c_str()), reinterpret_cast<GlobalMembersScraperParser.std.codecvt(Of )(GetBuf()))
'		Else
'			Debug.Assert(False)
'		End If
'	End Sub

'	Public Sub OemToAnsi()
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		If sizeof(CT) = sizeof(GlobalMembersScraperParser.std.codecvt<) AndAlso (Not empty()) Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'			OemToChar(reinterpret_cast<const GlobalMembersScraperParser.std.codecvt(Of )(Me.c_str()), reinterpret_cast<GlobalMembersScraperParser.std.codecvt(Of )(GetBuf()))
'		Else
'			Debug.Assert(False)
'		End If
'	End Sub

'#End If


'	' -------------------------------------------------------------------------
'	' Trim and its variants
'	' -------------------------------------------------------------------------
'	Public Function Trim() As CStdStr(Of CT)
'		Return TrimLeft().TrimRight()
'	End Function

'	Public Function TrimLeft() As CStdStr(Of CT)
'		Me.erase(Me.begin(), GlobalMembersScraperParser.std.find_if(Me.begin(), Me.end(), New NotSpace(Of CT)()))

'		Return Me
'	End Function

'	Public Function TrimLeft(ByVal tTrim As CT) As CStdStr(Of CT)
'		Me.erase(0, Me.find_first_not_of(tTrim))
'		Return Me
'	End Function

'	Public Function TrimLeft(ByVal szTrimChars As typename(Of CT)) As CStdStr(Of CT)
'		Me.erase(0, Me.find_first_not_of(szTrimChars))
'		Return Me
'	End Function

'	Public Function TrimRight() As CStdStr(Of CT)
'		' NOTE:  When comparing reverse_iterators here (MYRITER), I avoid using
'		' operator!=.  This is because namespace rel_ops also has a template
'		' operator!= which conflicts with the global operator!= already defined
'		' for reverse_iterator in the header <utility>.
'		' Thanks to John James for alerting me to this.

'		typename GlobalMembersScraperParser.std.basic_string(Of CT).reverse_iterator it = GlobalMembersScraperParser.std.find_if(Me.rbegin(), Me.rend(), New NotSpace(Of CT)())
'		If Not(Me.rend() = it) Then
'			Me.erase(Me.rend() - it)
'		End If

'		Me.erase(If(Not(it = Me.rend()), Me.find_last_of(*it) + 1, 0))
'		Return Me
'	End Function

'	Public Function TrimRight(ByVal tTrim As CT) As CStdStr(Of CT)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_last_not_of(tTrim)
''C++ TO VB CONVERTER TODO TASK: Assignments within expressions are not supported in VB.NET
''ORIGINAL LINE: Me->erase(std::basic_string(Of CT)::npos == nIdx ? 0 : ++nIdx);
'		Me.erase(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, 0, ++nIdx))
'		Return Me
'	End Function

'	Public Function TrimRight(ByVal szTrimChars As typename(Of CT)) As CStdStr(Of CT)
'		typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type nIdx = Me.find_last_not_of(szTrimChars)
''C++ TO VB CONVERTER TODO TASK: Assignments within expressions are not supported in VB.NET
''ORIGINAL LINE: Me->erase(std::basic_string(Of CT)::npos == nIdx ? 0 : ++nIdx);
'		Me.erase(GlobalMembersScraperParser.std.basic_string(Of CT).If(npos = nIdx, 0, ++nIdx))
'		Return Me
'	End Function

'	Public Sub FreeExtra()
'		Dim mt As New GlobalMembersScraperParser.CStdStr(Of CT)()
'		Me.swap(mt)
'		If (Not mt.empty()) Then
'			Me.assign(mt.c_str(), mt.size())
'		End If
'	End Sub

'	' I have intentionally not implemented the following CString
'	' functions.   You cannot make them work without taking advantage
'	' of implementation specific behavior.  However if you absolutely
'	' MUST have them, uncomment out these lines for "sort-of-like"
'	' their behavior.  You're on your own.

''	CT*				LockBuffer()	{ return GetBuf(); }// won't really lock
''	void			UnlockBuffer(); { }	// why have UnlockBuffer w/o LockBuffer?

'	' Array-indexing operators.  Required because we defined an implicit cast
'	' to operator const CT* (Thanks to Julian Selman for pointing this out)

'	Default Public ReadOnly Property Item(ByVal nIdx As Integer) As CT
'		Get
'			Return CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const CT& operator [](Integer nIdx) const
'	Default Public ReadOnly Property Item(ByVal nIdx As Integer) As CT
'		Get
'			Return CType(Me, const GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

'	Default Public ReadOnly Property Item(ByVal nIdx As UInteger) As CT
'		Get
'			Return CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const CT& operator [](UInteger nIdx) const
'	Default Public ReadOnly Property Item(ByVal nIdx As UInteger) As CT
'		Get
'			Return CType(Me, const GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

'	Default Public ReadOnly Property Item(ByVal nIdx As UInteger) As CT
'		Get
'			Return CType(Me, GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const CT& operator [](UInteger nIdx) const
'	Default Public ReadOnly Property Item(ByVal nIdx As UInteger) As CT
'		Get
'			Return CType(Me, const GlobalMembersScraperParser.std.basic_string(Of CT)).operator ()(CType(nIdx, typename GlobalMembersScraperParser.std.basic_string(Of CT).size_type))
'		End Get
'		Set
''C++ TO VB CONVERTER TODO TASK: C++ to VB Converter cannot determine the 'set' logic for this indexer:
'		End Set
'	End Property

'#If Not SS_NO_IMPLICIT_CAST Then
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: operator const CT*() const
'	Public Shared Operator CT*(ByVal ImpliedObject As CStdStr)
'		Return Me.c_str()
'	End Operator
'#End If

'	' IStream related functions.  Useful in IPersistStream implementations


'#If SS_INC_COMDEF Then
'	' struct SSSHDR - useful for non Std C++ persistence schemes.
'	Public Class SSSHDR
'		Public byCtrl As Byte
'		Public nChars As UInteger
'	End Class ' as in "Standard String Stream Header"


'	#Const SSSO_UNICODE = True
'	#Const SSSO_COMPRESS = True
'	' -------------------------------------------------------------------------
'	' FUNCTION: StreamSize
'	' REMARKS:
'	'		Returns how many bytes it will take to StreamSave() this CStdString
'	'		object to an IStream.
'	' -------------------------------------------------------------------------
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: UInteger StreamSize() const
'	Public Function StreamSize() As UInteger
'		' Control header plus string
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		Debug.Assert(Me.size()*sizeof(CT) < &HffffffffLUL - sizeof(SSSHDR))
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		Return (Me.size() * sizeof(CT)) + sizeof(SSSHDR)
'	End Function

'	' -------------------------------------------------------------------------
'	' FUNCTION: StreamSave
'	' REMARKS:
'	'		Saves this CStdString object to a COM IStream.
'	' -------------------------------------------------------------------------
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer StreamSave(IStream* pStream) const
'	Public Function StreamSave(ByRef pStream As IStream) As Integer
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		Debug.Assert(Me.size()*sizeof(CT) < &HffffffffLUL - sizeof(SSSHDR))
'		Dim hr As Integer = E_FAIL
'		Debug.Assert(pStream <> 0)
'		Dim hdr As New SSSHDR()
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		hdr.byCtrl = If(sizeof(CT) = 2, DefineConstantsScraperParser.SSSO_UNICODE, 0)
'		hdr.nChars = Me.size()


''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		hr =pStream.Write(hdr, sizeof(SSSHDR), 0)
'		If FAILEDhr Then
'			(_T("StreamSave: Cannot write control header, ERR=0x%X" & Constants.vbLf),hr)
'		ElseIf empty() Then
' ' nothing to write
''C++ TO VB CONVERTER TODO TASK: Assignments within expressions are not supported in VB.NET
''ORIGINAL LINE: else if (FAILED(hr=pStream->Write(Me->c_str(), Me->size()*sizeof(CT), 0)))
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		ElseIf FAILED(hr =pStream.Write(Me.c_str(), Me.size()*sizeof(CT), 0)) Then
'			(_T("StreamSave: Cannot write string to stream 0x%X" & Constants.vbLf), hr)
'		End If

'		Return hr
'	End Function


'	' -------------------------------------------------------------------------
'	' FUNCTION: StreamLoad
'	' REMARKS:
'	'		This method loads the object from an IStream.
'	' -------------------------------------------------------------------------
'	Public Function StreamLoad(ByRef pStream As IStream) As Integer
'		Debug.Assert(pStream <> 0)
'		Dim hdr As New SSSHDR()
'		Dim hr As Integer = E_FAIL

''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'		hr =pStream.Read(hdr, sizeof(SSSHDR), 0)
'		If FAILEDhr Then
'			(_T("StreamLoad: Cant read control header, ERR=0x%X" & Constants.vbLf), hr)
'		ElseIf hdr.nChars > 0 Then
'			Dim nRead As UInteger = 0
'			typename GlobalMembersScraperParser.std.basic_string(Of CT).pointer pMyBuf = BufferSet(hdr.nChars)

'			' If our character size matches the character size of the string
'			' we're trying to read, then we can read it directly into our
'			' buffer. Otherwise, we have to read into an intermediate buffer
'			' and convert.

'			If (hdr.byCtrl And DefineConstantsScraperParser.SSSO_UNICODE) <> 0 Then
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'				Dim nBytes As UInteger = hdr.nChars * sizeof(GlobalMembersScraperParser.std.codecvt<)
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'				If sizeof(CT) = sizeof(GlobalMembersScraperParser.std.codecvt<) Then
'					hr =pStream.Read(pMyBuf, nBytes, nRead)
'					If FAILEDhr Then
'						(_T("StreamLoad: Cannot read string: 0x%X" & Constants.vbLf), hr)
'					End If
'				Else
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'					GlobalMembersScraperParser.std.codecvt<* pBufW = reinterpret_cast<GlobalMembersScraperParser.std.codecvt(Of )(_alloca((nBytes)+1))
'					hr =pStream.Read(pBufW, nBytes, nRead)
'					If FAILEDhr Then
'						(_T("StreamLoad: Cannot read string: 0x%X" & Constants.vbLf), hr)
'					Else
'						GlobalMembersScraperParser.sscpy(pMyBuf, pBufW, hdr.nChars)
'					End If
'				End If
'			Else
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'				Dim nBytes As UInteger = hdr.nChars * sizeof(GlobalMembersScraperParser.std.codecvt<)
''C++ TO VB CONVERTER TODO TASK: There is no VB equivalent to 'sizeof':
'				If sizeof(CT) = sizeof(GlobalMembersScraperParser.std.codecvt<) Then
'					hr =pStream.Read(pMyBuf, nBytes, nRead)
'					If FAILEDhr Then
'						(_T("StreamLoad: Cannot read string: 0x%X" & Constants.vbLf), hr)
'					End If
'				Else
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in VB:
'					GlobalMembersScraperParser.std.codecvt<* pBufA = reinterpret_cast<GlobalMembersScraperParser.std.codecvt(Of )(_alloca(nBytes))
'					hr =pStream.Read(pBufA, hdr.nChars, nRead)
'					If FAILEDhr Then
'						(_T("StreamLoad: Cannot read string: 0x%X" & Constants.vbLf), hr)
'					Else
'						GlobalMembersScraperParser.sscpy(pMyBuf, pBufA, hdr.nChars)
'					End If
'				End If
'			End If
'		Else
'			Me.erase()
'		End If
'		Return hr
'	End Function
'#End If ' #ifdef SS_INC_COMDEF


'#If Not SS_ANSI Then
'	' SetResourceHandle/GetResourceHandle.  In MFC builds, these map directly
'	' to AfxSetResourceHandle and AfxGetResourceHandle.  In non-MFC builds they
'	' point to a single static HINST so that those who call the member
'	' functions that take resource IDs can provide an alternate HINST of a DLL
'	' to search.  This is not exactly the list of HMODULES that MFC provides
'	' but it's better than nothing.

'	#If _MFC_VER Then
'		Public Shared Sub SetResourceHandle(ByVal hNew As IntPtr)
'			AfxSetResourceHandle(hNew)
'		End Sub
'		Public Shared Function GetResourceHandle() As IntPtr
'			Return AfxGetResourceHandle()
'		End Function
'	#Else
'		Public Shared Sub SetResourceHandle(ByVal hNew As IntPtr)
'			GlobalMembersScraperParser.SSResourceHandle() = hNew
'		End Sub
'		Public Shared Function GetResourceHandle() As IntPtr
'			Return GlobalMembersScraperParser.SSResourceHandle()
'		End Function
'	#End If

'#End If
'End Class


'' New-style format function is a template

'#If SS_SAFE_FORMAT Then

''C++ TO VB CONVERTER WARNING: The original type declaration contained unconverted modifiers:
''ORIGINAL LINE: struct FmtArg<CStdStr(Of std::codecvt(Of ))
'Public Class CStdStr(Of std.codecvt(Of ))
'	Public FmtArg(ByVal arg As CStdStr(Of ))
'		a_ = arg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const std::codecvt<* operator ()() const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared std.codecvt<* Operator ()()
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		Return a_.c_str()
'	End Operator
'	 Public ReadOnly As GlobalMembersScraperParser.CStdStr <GlobalMembersScraperParser.std.codecvt(Of ) And a_
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: FmtArg<CStdStr(Of std::codecvt(Of ))& operator =(const FmtArg<CStdStr(Of std::codecvt(Of ))&)
'	Private FmtArg<Function CopyFrom(ByVal CStdStr As FmtArg(Of std.codecvt(Of ))) As CStdStr(Of std.codecvt(Of ))
'		Return Me
'	End Function
'End Class
''C++ TO VB CONVERTER WARNING: The original type declaration contained unconverted modifiers:
''ORIGINAL LINE: struct FmtArg<CStdStr(Of std::codecvt(Of ))
'Public Class CStdStr(Of std.codecvt(Of ))
'	Public FmtArg(ByVal arg As CStdStr(Of ))
'		a_ = arg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const std::codecvt<* operator ()() const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared std.codecvt<* Operator ()()
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		Return a_.c_str()
'	End Operator
'	 Public ReadOnly As GlobalMembersScraperParser.CStdStr <GlobalMembersScraperParser.std.codecvt(Of ) And a_
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: FmtArg<CStdStr(Of std::codecvt(Of ))& operator =(const FmtArg<CStdStr(Of std::codecvt(Of ))&)
'	Private FmtArg<Function CopyFrom(ByVal CStdStr As FmtArg(Of std.codecvt(Of ))) As CStdStr(Of std.codecvt(Of ))
'		Return Me
'	End Function
'End Class

'Public Class FmtArg(Of String)
'	Public Sub New(ByVal arg As String)
'		a_ = arg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const std::codecvt<* operator ()() const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared std.codecvt<* Operator ()()
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		Return a_.c_str()
'	End Operator
'	Public ReadOnly a_ As GlobalMembersScraperParser.String
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: FmtArg(Of String)& operator =(const FmtArg(Of String)&)
'	Private Function CopyFrom(ByVal UnnamedParameter1 As FmtArg(Of String)) As FmtArg(Of String)
'		Return Me
'	End Function
'End Class
'Public Class FmtArg(Of String)
'	Public Sub New(ByVal arg As String)
'		a_ = arg
'	End Sub
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: const std::codecvt<* operator ()() const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared std.codecvt<* Operator ()()
''C++ TO VB CONVERTER TODO TASK: The c_str method is not converted to VB:
'		Return a_.c_str()
'	End Operator
'	Public ReadOnly a_ As GlobalMembersScraperParser.String
''C++ TO VB CONVERTER NOTE: This 'CopyFrom' method was converted from the original C++ copy assignment operator:
''ORIGINAL LINE: FmtArg(Of String)& operator =(const FmtArg(Of String)&)
'	Private Function CopyFrom(ByVal UnnamedParameter1 As FmtArg(Of String)) As FmtArg(Of String)
'		Return Me
'	End Function
'End Class
'#End If ' #ifdef SS_SAFEFORMAT

'Public Class SSLNCW
'	Implements std.binary_function<CStdStr<std.codecvt(Of ), CStdStr(Of std.codecvt(Of ), Boolean)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline Boolean operator ()(const CStdStr<std::codecvt(Of )& sLeft, const CStdStr<std::codecvt(Of )& sRight) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal sLeft As CStdStr(Of ), ByVal sRight As CStdStr(Of )) As Boolean
'		Return GlobalMembersScraperParser.ssicmp(sLeft.c_str(), sRight.c_str()) < 0
'	End Operator
'End Class
'Public Class SSENCW
'	Implements std.binary_function<CStdStr<std.codecvt(Of ), CStdStr(Of std.codecvt(Of ), Boolean)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline Boolean operator ()(const CStdStr<std::codecvt(Of )& sLeft, const CStdStr<std::codecvt(Of )& sRight) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal sLeft As CStdStr(Of ), ByVal sRight As CStdStr(Of )) As Boolean
'		Return GlobalMembersScraperParser.ssicmp(sLeft.c_str(), sRight.c_str()) = 0
'	End Operator
'End Class
'Public Class SSLNCA
'	Implements std.binary_function<CStdStr<std.codecvt(Of ), CStdStr(Of std.codecvt(Of ), Boolean)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline Boolean operator ()(const CStdStr<std::codecvt(Of )& sLeft, const CStdStr<std::codecvt(Of )& sRight) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal sLeft As CStdStr(Of ), ByVal sRight As CStdStr(Of )) As Boolean
'		Return GlobalMembersScraperParser.ssicmp(sLeft.c_str(), sRight.c_str()) < 0
'	End Operator
'End Class
'Public Class SSENCA
'	Implements std.binary_function<CStdStr<std.codecvt(Of ), CStdStr(Of std.codecvt(Of ), Boolean)
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: inline Boolean operator ()(const CStdStr<std::codecvt(Of )& sLeft, const CStdStr<std::codecvt(Of )& sRight) const
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'	Public Shared Operator ()(ByVal sLeft As CStdStr(Of ), ByVal sRight As CStdStr(Of )) As Boolean
'		Return GlobalMembersScraperParser.ssicmp(sLeft.c_str(), sRight.c_str()) = 0
'	End Operator
'End Class

'' If we had to define our own version of TRACE above, get rid of it now

'#If TRACE_DEFINED_HERE Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''	#undef TRACE
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''	#undef TRACE_DEFINED_HERE
'#End If


'' These std::swap specializations come courtesy of Mike Crusader. 

''namespace std
''{
''	inline void swap(CStdStringA& s1, CStdStringA& s2) throw()
''	{
''		s1.swap(s2);
''	}
''	template<>
''	inline void swap(CStdStringW& s1, CStdStringW& s2) throw()
''	{
''		s1.swap(s2);
''	}
''}

'' Turn back on any Borland warnings we turned off.

'#If __BORLANDC__ Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in VB:
''	#pragma option pop ' Turn back on inline function warnings
''	#pragma warn +inl   // Turn back on inline function warnings
'#End If

'#End If ' #ifndef STDSTRING_H
''Tangible Process Only End


'#Const MAX_SCRAPER_BUFFERS = True

''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''class CHTTP;
''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''class CScraperSettings;

'Public Class CScraperParser
'  Public Sub New()
'	m_pRootElement = DefineConstantsScraperParser.NULL
'	m_content = DefineConstantsScraperParser.NULL
'	m_name = m_content
'	m_document = DefineConstantsScraperParser.NULL
'	m_settings = DefineConstantsScraperParser.NULL
'	m_SearchStringEncoding = "UTF-8"
'  End Sub
'  Public Sub Dispose()
'	m_pRootElement = DefineConstantsScraperParser.NULL
'	If m_document IsNot Nothing Then
'	  m_document.Dispose()
'	End If

'	m_document = DefineConstantsScraperParser.NULL
'	m_content = DefineConstantsScraperParser.NULL
'	m_name = m_content
'	m_settings = DefineConstantsScraperParser.NULL
'  End Sub

'  Public Function Load(ByVal strXMLFile As std.map) As Boolean
'	If m_document IsNot Nothing Then
'	  Return True
'	End If

'	m_document = New TiXmlDocument(CUtil.TranslatePath(strXMLFile).c_str())

'	If m_document Is Nothing Then
'	  Return False
'	End If

'	If m_document.LoadFile() Then
'	  m_pRootElement = m_document.RootElement()
'	  GlobalMembersScraperParser.std.map< strValue = m_pRootElement.Value()
'	  If strValue <> "scraper" Then
'		m_document.Dispose()
'		m_document = DefineConstantsScraperParser.NULL
'		m_pRootElement = DefineConstantsScraperParser.NULL
'		Return False
'	  End If

'	  m_name = m_pRootElement.Attribute("name")
'	  m_content = m_pRootElement.Attribute("content")

'	  If (Not m_name) OrElse (Not m_content) Then ' FIXME
'		m_document.Dispose()
'		m_document = DefineConstantsScraperParser.NULL
'		m_pRootElement = DefineConstantsScraperParser.NULL
'		Return False
'	  End If
'	  ' check for known content
'	  If String.Compare(m_content,"tvshows", True) AndAlso String.Compare(m_content,"movies", True) AndAlso String.Compare(m_content,"musicvideos", True) AndAlso String.Compare(m_content,"albums", True) Then
'		m_document.Dispose()
'		m_document = DefineConstantsScraperParser.NULL
'		m_pRootElement = DefineConstantsScraperParser.NULL
'		Return False
'	  End If

'	  Dim pChildElement As TiXmlElement = m_pRootElement.FirstChildElement("CreateSearchUrl")
'	  If pChildElement IsNot Nothing Then
'		m_SearchStringEncoding = pChildElement.Attribute("SearchStringEncoding")
'		If (Not m_SearchStringEncoding) Then
'		  m_SearchStringEncoding = "UTF-8"
'		End If
'	  End If
'	Else
'	  m_document.Dispose()
'	  m_document = DefineConstantsScraperParser.NULL
'	  Return False
'	End If

'	Return True
'  End Function
'  Public Function GetName() As CStdString
'	  Return m_name
'  End Function
'  Public Function GetContent() As CStdString
'	  Return m_content
'  End Function
'  Public Function GetSearchStringEncoding() As CStdString
'	  Return m_SearchStringEncoding
'  End Function
'  Public std.map< Parse(ByVal strTag As std.map, Optional ByVal pSettings As CScraperSettings = Nothing)
'	Dim pChildElement As TiXmlElement = m_pRootElement.FirstChildElement(strTag.c_str())
'	If pChildElement Is DefineConstantsScraperParser.NULL Then
'		Return ""
'	End If
'	Dim iResult As Integer = 1 ' default to param 1
'	pChildElement.QueryIntAttribute("dest", iResult)
'	Dim pChildStart As TiXmlElement = pChildElement.FirstChildElement("RegExp")
'	If pSettings IsNot Nothing Then
'	  m_settings = pSettings
'	Else
'	  m_settings = DefineConstantsScraperParser.NULL
'	End If
'	ParseNext(pChildStart)
'	GlobalMembersScraperParser.std.map< tmp = m_param(iResult-1)

'	Dim szClearBuffers As GlobalMembersScraperParser.String = pChildElement.Attribute("clearbuffers")
'	If szClearBuffers Is Nothing OrElse String.Compare(szClearBuffers,"no", True) <> 0 Then
'	  ClearBuffers()
'	End If

'	Return tmp
'  End Function
'  Public Function HasFunction(ByVal strTag As std.map) As Boolean
'	Dim pChildElement As TiXmlElement = m_pRootElement.FirstChildElement(strTag.c_str())

'	If pChildElement Is Nothing Then
'	  Return False
'	End If

'	Return True
'  End Function

'  Public m_param(DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1) As CStdString
'  Public Shared Sub ClearCache()
'	' wipe cache
'	GlobalMembersScraperParser.std.map< strCachePath
'	CUtil.AddFileToFolder(g_advancedSettings.m_cachePath, "scrapers", strCachePath)
'	CUtil.WipeDir(strCachePath)
'	DIRECTORY.CDirectory.Create(strCachePath)
'  End Sub

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub ReplaceBuffers(ByRef strDest As CStdString)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub ParseExpression(ByVal input As CStdString, ByRef dest As CStdString, ByVal element As TiXmlElement, ByVal bAppend As Boolean)
'  Private Sub ParseNext(ByVal element As TiXmlElement)
''C++ TO VB CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged.
''C++ TO VB CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
''ORIGINAL LINE: TiXmlElement* pReg = element;
'	Dim pReg As TiXmlElement * = New TiXmlElement(element)
'	Do While pReg IsNot Nothing
'	  Dim pChildReg As TiXmlElement = pReg.FirstChildElement("RegExp")
'	  If pChildReg IsNot Nothing Then
'		ParseNext(pChildReg)
'	  Else
'		Dim pChildReg As TiXmlElement = pReg.FirstChildElement("clear")
'		If pChildReg IsNot Nothing Then
'		  ParseNext(pChildReg)
'		End If
'	  End If

'	  Dim iDest As Integer = 1
'	  Dim bAppend As Boolean = False
'	  Dim szDest As GlobalMembersScraperParser.String = pReg.Attribute("dest")
'	  If szDest IsNot Nothing Then
'		If szDest.Length Then
'		  If szDest.Chars(szDest.Length-1) = "+"c Then
'			bAppend = True
'		  End If

'		  iDest = Convert.ToInt32(szDest)
'		End If
'	  End If

'		Dim szInput As GlobalMembersScraperParser.String = pReg.Attribute("input")
'		GlobalMembersScraperParser.std.map< strInput
'		If szInput IsNot Nothing Then
'		  strInput = szInput
'		  ReplaceBuffers(strInput)
'		Else
'		  strInput = m_param(0)
'		End If

'		Dim szConditional As GlobalMembersScraperParser.String = pReg.Attribute("conditional")
'		Dim bExecute As Boolean = True
'		If szConditional IsNot Nothing Then
'		  Dim bInverse As Boolean =False
'		  If szConditional.Chars(0) = "!"c Then
'			bInverse = True
'			szConditional &= 1
'		  End If
'		  GlobalMembersScraperParser.std.map< strSetting
'		  If m_settings IsNot Nothing Then
'			 strSetting = m_settings.Get(szConditional)
'		  End If
'		  If strSetting.IsEmpty() Then ' setting isnt around - treat as if the value is false
'			bExecute = Not bInverse
'		  Else
'			bExecute = If(bInverse, (Not strSetting.Equals("true")), strSetting.Equals("true"))
'		  End If
'		End If

'		If bExecute Then
'		  ParseExpression(strInput, m_param(iDest-1), pReg, bAppend)
'		End If

'		pReg = pReg.NextSiblingElement("RegExp")
'	Loop
'  End Sub
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub Clean(ByRef strDirty As CStdString)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  std::codecvt<* RemoveWhiteSpace(ByVal String As std::codecvt)
'  Private Sub ClearBuffers()
'	'clear all m_param strings
'	For i As Integer = 0 To DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1
'	  m_param(i).clear()
'	Next i
'  End Sub

'  Private m_document As TiXmlDocument
'  Private m_pRootElement As TiXmlElement

'   Private ReadOnly As GlobalMembersScraperParser.std.codecvt <* m_name
'   Private ReadOnly As GlobalMembersScraperParser.std.codecvt <* m_content
'   Private ReadOnly As GlobalMembersScraperParser.std.codecvt <* m_SearchStringEncoding

'  Private m_settings As CScraperSettings
'End Class

'#End If




'#If _LINUX Then

''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_XBOX_D3D
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_RAM_CONTROL
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_XFONT
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FILESYSTEM_CDDA
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FILESYSTEM_SMB
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FILESYSTEM_RTV
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FILESYSTEM_DAAP
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FILESYSTEM
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_GAMEPAD
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_IR_REMOTE
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_DVD_DRIVE
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_XBOX_HARDWARE
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_XBOX_NETWORK
'#If HAS_SDL Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_VIDEO_PLAYBACK
'#Const HAS_VIDEO_PLAYBACK = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVDPLAYER
'#Const HAS_DVDPLAYER = True
'#Else
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_VIDEO_PLAYBACK
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_DVDPLAYER
'#End If
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_MPLAYER
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_AC3_CODEC
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_DTS_CODEC
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_AC3_CDDA_CODEC
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_DTS_CDDA_CODEC
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_WMA_CODEC
'#Const HAS_WMA_CODEC = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_XBOX_AUDIO
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_AUDIO_PASS_THROUGH
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_FTP_SERVER
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_WEB_SERVER
'#Const HAS_WEB_SERVER = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_TIME_SERVER
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_VISUALISATION
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_KARAOKE
'#Const HAS_KARAOKE = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_CREDITS
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_MODPLAYER
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_SYSINFO
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SCREENSAVER
'#Const HAS_SCREENSAVER = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_MIKMOD
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_SECTIONS
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_UPNP
'#Const HAS_UPNP = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_LCD
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_UNDOCUMENTED
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_SECTIONS
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_CDDA_RIPPER
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_PYTHON
'#Const HAS_PYTHON = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_AUDIO
'#Const HAS_AUDIO = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SHOUTCAST
'#Const HAS_SHOUTCAST = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_RAR
'#Const HAS_RAR = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_LIRC

'#If Not _LINUX Then
'' additional includes and defines
'#If Not(_WINSOCKAPI_ OrElse _WINSOCK_H) Then
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <winsock2.h>
'#End If
'#Const DIRECTINPUT_VERSION = True
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include "DInput.h"
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include "DSound.h"
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define DSSPEAKER_USE_DEFAULT DSSPEAKER_STEREO
'#Const DSSPEAKER_USE_DEFAULT = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define LPDIRECTSOUND8 LPDIRECTSOUND
'#Const LPDIRECTSOUND8 = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef GetFreeSpace
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_CCXSTREAM
'#End If

'#If _LINUX Then
'#If Not __APPLE__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_LCD
'#Const HAS_LCD = True
'' include/config.h.  Generated by configure.  
'' include/config.h.in.  Generated from configure.in by autoheader.  

'' Whether the host os is aix 
'' #undef AIX 

'' Whether the AIX send_file() API is available 
'' #undef AIX_SENDFILE_API 

'' Does extattr API work 
'' #undef BROKEN_EXTATTR 

'' Does getgrnam work correctly 
'' #undef BROKEN_GETGRNAM 

'' Whether the nisplus include files are broken 
'#Const BROKEN_NISPLUS_INCLUDE_FILES = True

'' Broken RedHat 7.2 system header files 
'' #undef BROKEN_REDHAT_7_SYSTEM_HEADERS 

'' Does strndup work correctly 
'' #undef BROKEN_STRNDUP 

'' Does strnlen work correctly 
'' #undef BROKEN_STRNLEN 

'' Does this system use unicode compose characters 
'' #undef BROKEN_UNICODE_COMPOSE_CHARACTERS 

'' Whether the compiler supports the LL prefix on long long integers 
'#Const COMPILER_SUPPORTS_LL = True

'' Whether the host os is Darwin/MacOSX 
'' #undef DARWINOS 

'' Default display charset name 
'#Const DEFAULT_DISPLAY_CHARSET = True

'' Default dos charset name 
'#Const DEFAULT_DOS_CHARSET = True

'' Default unix charset name 
'#Const DEFAULT_UNIX_CHARSET = True

'' Define to check invariants around some common functions 
'' #undef DMALLOC_FUNC_CHECK 

'' Define to turn on dmalloc debugging 
'' #undef ENABLE_DMALLOC 

'' Whether the host os is FreeBSD 
'' #undef FREEBSD 

'' Whether the FreeBSD sendfile() API is available 
'' #undef FREEBSD_SENDFILE_API 

'' Whether we are running on 64bit linux 
'' #undef HAVE_64BIT_LINUX 

'' Whether acl_get_perm_np() is available 
'' #undef HAVE_ACL_GET_PERM_NP 

'' Whether the krb5_address struct has a addrtype property 
'' #undef HAVE_ADDRTYPE_IN_KRB5_ADDRESS 

'' Whether the krb5_address struct has a addr_type property 
'' #undef HAVE_ADDR_TYPE_IN_KRB5_ADDRESS 

'' Define to 1 if you have the `add_proplist_entry' function. 
'' #undef HAVE_ADD_PROPLIST_ENTRY 

'' Define to 1 if you have the <afs/afs.h> header file. 
'' #undef HAVE_AFS_AFS_H 

'' Define to 1 if you have the <afs.h> header file. 
'' #undef HAVE_AFS_H 

'' Whether 64 bit aio is available 
'' #undef HAVE_AIOCB64 

'' Have aio_cancel 
'' #undef HAVE_AIO_CANCEL 

'' Have aio_cancel64 
'' #undef HAVE_AIO_CANCEL64 

'' Have aio_error 
'' #undef HAVE_AIO_ERROR 

'' Have aio_error64 
'' #undef HAVE_AIO_ERROR64 

'' Have aio_fsync 
'' #undef HAVE_AIO_FSYNC 

'' Have aio_fsync64 
'' #undef HAVE_AIO_FSYNC64 

'' Define to 1 if you have the <aio.h> header file. 
'' #undef HAVE_AIO_H 

'' Have aio_read 
'' #undef HAVE_AIO_READ 

'' Have aio_read64 
'' #undef HAVE_AIO_READ64 

'' Have aio_return 
'' #undef HAVE_AIO_RETURN 

'' Have aio_return64 
'' #undef HAVE_AIO_RETURN64 

'' Have aio_suspend 
'' #undef HAVE_AIO_SUSPEND 

'' Have aio_suspend64 
'' #undef HAVE_AIO_SUSPEND64 

'' Have aio_write 
'' #undef HAVE_AIO_WRITE 

'' Have aio_write64 
'' #undef HAVE_AIO_WRITE64 

'' Whether AIX ACLs are available 
'' #undef HAVE_AIX_ACLS 

'' Define to 1 if you have the <alloca.h> header file. 
'' #undef HAVE_ALLOCA_H 

'' Whether the AP_OPTS_USE_SUBKEY ap option is available 
'' #undef HAVE_AP_OPTS_USE_SUBKEY 

'' Define to 1 if you have the <arpa/inet.h> header file. 
'' #undef HAVE_ARPA_INET_H 

'' check for <asm/types.h> 
'' #undef HAVE_ASM_TYPES_H 

'' Define to 1 if you have the `asprintf' function. 
'' #undef HAVE_ASPRINTF 

'' Whether asprintf() is available 
'' #undef HAVE_ASPRINTF_DECL 

'' Define to 1 if you have the `atexit' function. 
'#Const HAVE_ATEXIT = True

'' Define to 1 if you have the `attr_get' function. 
'' #undef HAVE_ATTR_GET 

'' Define to 1 if you have the `attr_getf' function. 
'' #undef HAVE_ATTR_GETF 

'' Define to 1 if you have the `attr_list' function. 
'' #undef HAVE_ATTR_LIST 

'' Define to 1 if you have the `attr_listf' function. 
'' #undef HAVE_ATTR_LISTF 

'' Define to 1 if you have the `attr_remove' function. 
'' #undef HAVE_ATTR_REMOVE 

'' Define to 1 if you have the `attr_removef' function. 
'' #undef HAVE_ATTR_REMOVEF 

'' Define to 1 if you have the `attr_set' function. 
'' #undef HAVE_ATTR_SET 

'' Define to 1 if you have the `attr_setf' function. 
'' #undef HAVE_ATTR_SETF 

'' Define to 1 if you have the <attr/xattr.h> header file. 
'' #undef HAVE_ATTR_XATTR_H 

'' Define to 1 if you have the `backtrace_symbols' function. 
'' #undef HAVE_BACKTRACE_SYMBOLS 

'' Define to 1 if you have the `ber_scanf' function. 
'' #undef HAVE_BER_SCANF 

'' What header to include for iconv() function: biconv.h 
'' #undef HAVE_BICONV 

'' Whether bigcrypt is available 
'' #undef HAVE_BIGCRYPT 

'' Whether fcntl64 locks are broken 
'' #undef HAVE_BROKEN_FCNTL64_LOCKS 

'' Whether getgroups is broken 
'' #undef HAVE_BROKEN_GETGROUPS 

'' Whether readdir() returns the wrong name offset 
'' #undef HAVE_BROKEN_READDIR_NAME 

'' Whether there is a C99 compliant vsnprintf 
'' #undef HAVE_C99_VSNPRINTF 

'' Whether cap_get_proc is available 
'' #undef HAVE_CAP_GET_PROC 

'' Define to 1 if you have the <CFStringEncodingConverter.h> header file. 
'' #undef HAVE_CFSTRINGENCODINGCONVERTER_H 

'' Whether the krb5_checksum struct has a checksum property 
'' #undef HAVE_CHECKSUM_IN_KRB5_CHECKSUM 

'' Define to 1 if you have the `chmod' function. 
'#Const HAVE_CHMOD = True

'' Define to 1 if you have the `chown' function. 
'' #undef HAVE_CHOWN 

'' Define to 1 if you have the `chroot' function. 
'' #undef HAVE_CHROOT 

'' Define to 1 if you have the `chsize' function. 
'' #undef HAVE_CHSIZE 1 

'' Whether clock_gettime is available 
'' #undef HAVE_CLOCK_GETTIME 

'' Whether the clock_gettime clock ID CLOCK_MONOTONIC is available 
'' #undef HAVE_CLOCK_MONOTONIC 

'' Whether the clock_gettime clock ID CLOCK_PROCESS_CPUTIME_ID is available 
'' #undef HAVE_CLOCK_PROCESS_CPUTIME_ID 

'' Whether the clock_gettime clock ID CLOCK_REALTIME is available 
'' #undef HAVE_CLOCK_REALTIME 

'' Define to 1 if you have the `closedir64' function. 
'' #undef HAVE_CLOSEDIR64 

'' Whether the compiler will optimize out function calls 
'' #undef HAVE_COMPILER_WILL_OPTIMIZE_OUT_FNS 1 

'' Define to 1 if you have the <com_err.h> header file. 
'' #undef HAVE_COM_ERR_H 

'' Whether the system has connect() 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAVE_CONNECT
'#Const HAVE_CONNECT = True

'' Define to 1 if you have the `copy_Authenticator' function. 
'' #undef HAVE_COPY_AUTHENTICATOR 

'' Define to 1 if you have the <CoreFoundation/CFStringEncodingConverter.h>
''   header file. 
'' #undef HAVE_COREFOUNDATION_CFSTRINGENCODINGCONVERTER_H 

'' Define to 1 if you have the `creat64' function. 
'' #undef HAVE_CREAT64 

'' Whether the system has the crypt() function 
'' #undef HAVE_CRYPT 

'' Define to 1 if you have the `crypt16' function. 
'' #undef HAVE_CRYPT16 

'' Define to 1 if you have the <ctype.h> header file. 
'#Const HAVE_CTYPE_H = True

'' Whether we have CUPS 
'' #undef HAVE_CUPS 

'' Define to 1 if you have the `decode_krb5_ap_req' function. 
'' #undef HAVE_DECODE_KRB5_AP_REQ 

'' Define to 1 if you have the `delproplist' function. 
'' #undef HAVE_DELPROPLIST 

'' Define to 1 if you have the `des_set_key' function. 
'' #undef HAVE_DES_SET_KEY 

'' Whether the 'dev64_t' type is available 
'' #undef HAVE_DEV64_T 

'' Whether the major macro for dev_t is available 
'' #undef HAVE_DEVICE_MAJOR_FN 

'' Whether the minor macro for dev_t is available 
'' #undef HAVE_DEVICE_MINOR_FN 

'' Define to 1 if you have the `devnm' function. 
'' #undef HAVE_DEVNM 

'' Define to 1 if you have the <devnm.h> header file. 
'' #undef HAVE_DEVNM_H 

'' Whether dirent has a d_off member 
'' #undef HAVE_DIRENT_D_OFF 

'' Define to 1 if you have the <dirent.h> header file, and it defines `DIR'.
''   
'#Const HAVE_DIRENT_H = True

'' Define to 1 if you have the `dlclose' function. 
'' #undef HAVE_DLCLOSE 

'' Define to 1 if you have the `dlerror' function. 
'' #undef HAVE_DLERROR 

'' Define to 1 if you have the <dlfcn.h> header file. 
'' #undef HAVE_DLFCN_H 

'' Define to 1 if you have the `dlopen' function. 
'' #undef HAVE_DLOPEN 

'' Define to 1 if you have the `dlsym' function. 
'' #undef HAVE_DLSYM 

'' Define to 1 if you have the `dlsym_prepend_underscore' function. 
'' #undef HAVE_DLSYM_PREPEND_UNDERSCORE 

'' struct dqblk .dqb_fsoftlimit 
'' #undef HAVE_DQB_FSOFTLIMIT 

'' Define to 1 if you have the `dup2' function. 
'#Const HAVE_DUP2 = True

'' Whether the ENCTYPE_ARCFOUR_HMAC_MD5 key type is available 
'' #undef HAVE_ENCTYPE_ARCFOUR_HMAC_MD5 

'' Define to 1 if you have the `endmntent' function. 
'' #undef HAVE_ENDMNTENT 

'' Define to 1 if you have the `endnetgrent' function. 
'' #undef HAVE_ENDNETGRENT 

'' Whether errno() is available 
'' #undef HAVE_ERRNO_DECL 1 

'' Whether the EncryptedData struct has a etype property 
'' #undef HAVE_ETYPE_IN_ENCRYPTEDDATA 

'' Define to 1 if you have the <execinfo.h> header file. 
'' #undef HAVE_EXECINFO_H 

'' Define to 1 if you have the `execl' function. 
'#Const HAVE_EXECL = True

'' Whether large file support can be enabled 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAVE_EXPLICIT_LARGEFILE_SUPPORT
'#Const HAVE_EXPLICIT_LARGEFILE_SUPPORT = True

'' Define to 1 if you have the `extattr_delete_fd' function. 
'' #undef HAVE_EXTATTR_DELETE_FD 

'' Define to 1 if you have the `extattr_delete_file' function. 
'' #undef HAVE_EXTATTR_DELETE_FILE 

'' Define to 1 if you have the `extattr_delete_link' function. 
'' #undef HAVE_EXTATTR_DELETE_LINK 

'' Define to 1 if you have the `extattr_get_fd' function. 
'' #undef HAVE_EXTATTR_GET_FD 

'' Define to 1 if you have the `extattr_get_file' function. 
'' #undef HAVE_EXTATTR_GET_FILE 

'' Define to 1 if you have the `extattr_get_link' function. 
'' #undef HAVE_EXTATTR_GET_LINK 

'' Define to 1 if you have the `extattr_list_fd' function. 
'' #undef HAVE_EXTATTR_LIST_FD 

'' Define to 1 if you have the `extattr_list_file' function. 
'' #undef HAVE_EXTATTR_LIST_FILE 

'' Define to 1 if you have the `extattr_list_link' function. 
'' #undef HAVE_EXTATTR_LIST_LINK 

'' Define to 1 if you have the `extattr_set_fd' function. 
'' #undef HAVE_EXTATTR_SET_FD 

'' Define to 1 if you have the `extattr_set_file' function. 
'' #undef HAVE_EXTATTR_SET_FILE 

'' Define to 1 if you have the `extattr_set_link' function. 
'' #undef HAVE_EXTATTR_SET_LINK 

'' Whether the krb5_error struct has a e_data pointer 
'' #undef HAVE_E_DATA_POINTER_IN_KRB5_ERROR 

'' Define to 1 if you have the `FAMOpen2' function. 
'' #undef HAVE_FAMOPEN2 

'' Whether FAM is file notifications are available 
'' #undef HAVE_FAM_CHANGE_NOTIFY 

'' Define to 1 if you have the <fam.h> header file. 
'' #undef HAVE_FAM_H 

'' Whether fam.h contains a typedef for enum FAMCodes 
'' #undef HAVE_FAM_H_FAMCODES_TYPEDEF 

'' Define to 1 if you have the `fchmod' function. 
'' #undef HAVE_FCHMOD 

'' Define to 1 if you have the `fchown' function. 
'' #undef HAVE_FCHOWN 

'' Define to 1 if you have the <fcntl.h> header file. 
'#Const HAVE_FCNTL_H = True

'' Whether fcntl locking is available 
'' #undef HAVE_FCNTL_LOCK 

'' Define to 1 if you have the `fcvt' function. 
'#Const HAVE_FCVT = True

'' Define to 1 if you have the `fcvtl' function. 
'' #undef HAVE_FCVTL 

'' Define to 1 if you have the `fdelproplist' function. 
'' #undef HAVE_FDELPROPLIST 

'' Define to 1 if you have the `fgetea' function. 
'' #undef HAVE_FGETEA 

'' Define to 1 if you have the `fgetproplist' function. 
'' #undef HAVE_FGETPROPLIST 

'' Define to 1 if you have the `fgetxattr' function. 
'' #undef HAVE_FGETXATTR 

'' Define to 1 if you have the `flistea' function. 
'' #undef HAVE_FLISTEA 

'' Define to 1 if you have the `flistxattr' function. 
'' #undef HAVE_FLISTXATTR 

'' Define to 1 if you have the <float.h> header file. 
'' #undef HAVE_FLOAT_H 

'' Define to 1 if you have the `fopen64' function. 
'' #undef HAVE_FOPEN64 

'' Define to 1 if you have the `free_AP_REQ' function. 
'' #undef HAVE_FREE_AP_REQ 

'' Define to 1 if you have the `fremoveea' function. 
'' #undef HAVE_FREMOVEEA 

'' Define to 1 if you have the `fremovexattr' function. 
'' #undef HAVE_FREMOVEXATTR 

'' Define to 1 if you have the `fseek64' function. 
'' #undef HAVE_FSEEK64 

'' Define to 1 if you have the `fseeko64' function. 
'' #undef HAVE_FSEEKO64 

'' Define to 1 if you have the `fsetea' function. 
'' #undef HAVE_FSETEA 

'' Define to 1 if you have the `fsetproplist' function. 
'' #undef HAVE_FSETPROPLIST 

'' Define to 1 if you have the `fsetxattr' function. 
'' #undef HAVE_FSETXATTR 

'' Define to 1 if you have the `fstat' function. 
'#Const HAVE_FSTAT = True

'' Whether fstat64() is available 
'#Const HAVE_FSTAT64 = True

'' Define to 1 if you have the `fsync' function. 
'' #undef HAVE_FSYNC 

'' Define to 1 if you have the `ftell64' function. 
'' #undef HAVE_FTELL64 

'' Define to 1 if you have the `ftello64' function. 
'' #undef HAVE_FTELLO64 1 

'' Define to 1 if you have the `ftruncate' function. 
'#Const HAVE_FTRUNCATE = True

'' Define to 1 if you have the `ftruncate64' function. 
'' #undef HAVE_FTRUNCATE64 

'' Truncate extend 
'' #undef HAVE_FTRUNCATE_EXTEND 

'' Whether there is a __FUNCTION__ macro 
'#Const HAVE_FUNCTION_MACRO = True

'' Define to 1 if you have the `getauthuid' function. 
'' #undef HAVE_GETAUTHUID 

'' Define to 1 if you have the `getcwd' function. 
'#Const HAVE_GETCWD = True

'' Define to 1 if you have the `getdents' function. 
'' #undef HAVE_GETDENTS 

'' Define to 1 if you have the `getdents64' function. 
'' #undef HAVE_GETDENTS64 

'' Define to 1 if you have the `getdirentries' function. 
'' #undef HAVE_GETDIRENTRIES 

'' Define to 1 if you have the `getea' function. 
'' #undef HAVE_GETEA 

'' Define to 1 if you have the `getgrent' function. 
'' #undef HAVE_GETGRENT 

'' Define to 1 if you have the `getgrnam' function. 
'' #undef HAVE_GETGRNAM 

'' Define to 1 if you have the `getgrouplist' function. 
'' #undef HAVE_GETGROUPLIST 

'' Define to 1 if you have the `getmntent' function. 
'' #undef HAVE_GETMNTENT 

'' Define to 1 if you have the `getnetgrent' function. 
'' #undef HAVE_GETNETGRENT 

'' Define to 1 if you have the `getproplist' function. 
'' #undef HAVE_GETPROPLIST 

'' Whether getprpwnam is available 
'' #undef HAVE_GETPRPWNAM 

'' Define to 1 if you have the `getpwanam' function. 
'' #undef HAVE_GETPWANAM 

'' Define to 1 if you have the `getrlimit' function. 
'' #undef HAVE_GETRLIMIT 

'' Whether getspnam is available 
'' #undef HAVE_GETSPNAM 

'' Whether gettimeofday() is available 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAVE_GETTIMEOFDAY_TZ
'#Const HAVE_GETTIMEOFDAY_TZ = True

'' Define to 1 if you have the `getutmpx' function. 
'' #undef HAVE_GETUTMPX 

'' Define to 1 if you have the `getxattr' function. 
'' #undef HAVE_GETXATTR 

'' Define to 1 if you have the `get_proplist_entry' function. 
'' #undef HAVE_GET_PROPLIST_ENTRY 

'' What header to include for iconv() function: giconv.h 
'' #undef HAVE_GICONV 

'' Define to 1 if you have the `glob' function. 
'' #undef HAVE_GLOB 

'' Define to 1 if you have the <glob.h> header file. 
'' #undef HAVE_GLOB_H 

'' Define to 1 if you have the `grantpt' function. 
'' #undef HAVE_GRANTPT 

'' Define to 1 if you have the <grp.h> header file. 
'' #undef HAVE_GRP_H 

'' Whether GSSAPI is available 
'' #undef HAVE_GSSAPI 

'' Define to 1 if you have the <gssapi/gssapi_generic.h> header file. 
'' #undef HAVE_GSSAPI_GSSAPI_GENERIC_H 

'' Define to 1 if you have the <gssapi/gssapi.h> header file. 
'' #undef HAVE_GSSAPI_GSSAPI_H 

'' Define to 1 if you have the <gssapi.h> header file. 
'' #undef HAVE_GSSAPI_H 

'' Define to 1 if you have the `gss_display_status' function. 
'' #undef HAVE_GSS_DISPLAY_STATUS 

'' Define to 1 if you have the <history.h> header file. 
'' #undef HAVE_HISTORY_H 

'' Whether HPUX ACLs are available 
'' #undef HAVE_HPUX_ACLS 

'' What header to include for iconv() function: iconv.h 
'#Const HAVE_ICONV = True

'' Whether iface AIX is available 
'' #undef HAVE_IFACE_AIX 

'' Whether iface ifconf is available 
'' #undef HAVE_IFACE_IFCONF 

'' Whether iface ifreq is available 
'' #undef HAVE_IFACE_IFREQ 

'' Whether the compiler supports immediate structures 
'' #undef HAVE_IMMEDIATE_STRUCTURES 

'' Define to 1 if you have the `initgroups' function. 
'' #undef HAVE_INITGROUPS 

'' Define to 1 if you have the `innetgr' function. 
'' #undef HAVE_INNETGR 

'' Whether the 'ino64_t' type is available 
'' #undef HAVE_INO64_T 

'' Whether int16 typedef is included by rpc/rpc.h 
'' #undef HAVE_INT16_FROM_RPC_RPC_H 

'' Whether int32 typedef is included by rpc/rpc.h 
'' #undef HAVE_INT32_FROM_RPC_RPC_H 

'' Define to 1 if you have the <inttypes.h> header file. 
'' #undef HAVE_INTTYPES_H 

'' Whether we have iPrint 
'' #undef HAVE_IPRINT 

'' Whether IRIX ACLs are available 
'' #undef HAVE_IRIX_ACLS 

'' Whether kernel notifies changes 
'' #undef HAVE_KERNEL_CHANGE_NOTIFY 

'' Whether IRIX kernel oplock type definitions are available 
'' #undef HAVE_KERNEL_OPLOCKS_IRIX 

'' Whether to use linux kernel oplocks 
'' #undef HAVE_KERNEL_OPLOCKS_LINUX 

'' Whether the kernel supports share modes 
'' #undef HAVE_KERNEL_SHARE_MODES 

'' Whether to have KRB5 support 
'' #undef HAVE_KRB5 

'' Whether the type krb5_addresses type exists 
'' #undef HAVE_KRB5_ADDRESSES 

'' Define to 1 if you have the `krb5_auth_con_setkey' function. 
'' #undef HAVE_KRB5_AUTH_CON_SETKEY 

'' Define to 1 if you have the `krb5_auth_con_setuseruserkey' function. 
'' #undef HAVE_KRB5_AUTH_CON_SETUSERUSERKEY 

'' Whether the type krb5_crypto exists 
'' #undef HAVE_KRB5_CRYPTO 

'' Define to 1 if you have the `krb5_crypto_destroy' function. 
'' #undef HAVE_KRB5_CRYPTO_DESTROY 

'' Define to 1 if you have the `krb5_crypto_init' function. 
'' #undef HAVE_KRB5_CRYPTO_INIT 

'' Define to 1 if you have the `krb5_c_enctype_compare' function. 
'' #undef HAVE_KRB5_C_ENCTYPE_COMPARE 

'' Define to 1 if you have the `krb5_c_verify_checksum' function. 
'' #undef HAVE_KRB5_C_VERIFY_CHECKSUM 

'' Define to 1 if you have the `krb5_decode_ap_req' function. 
'' #undef HAVE_KRB5_DECODE_AP_REQ 

'' Whether the type krb5_encrypt_block exists 
'' #undef HAVE_KRB5_ENCRYPT_BLOCK 

'' Define to 1 if you have the `krb5_encrypt_data' function. 
'' #undef HAVE_KRB5_ENCRYPT_DATA 

'' Define to 1 if you have the `krb5_enctypes_compatible_keys' function. 
'' #undef HAVE_KRB5_ENCTYPES_COMPATIBLE_KEYS 

'' Define to 1 if you have the `krb5_free_ap_req' function. 
'' #undef HAVE_KRB5_FREE_AP_REQ 

'' Define to 1 if you have the `krb5_free_data_contents' function. 
'' #undef HAVE_KRB5_FREE_DATA_CONTENTS 

'' Define to 1 if you have the `krb5_free_error_contents' function. 
'' #undef HAVE_KRB5_FREE_ERROR_CONTENTS 

'' Define to 1 if you have the `krb5_free_keytab_entry_contents' function. 
'' #undef HAVE_KRB5_FREE_KEYTAB_ENTRY_CONTENTS 

'' Define to 1 if you have the `krb5_free_ktypes' function. 
'' #undef HAVE_KRB5_FREE_KTYPES 

'' Define to 1 if you have the `krb5_free_unparsed_name' function. 
'' #undef HAVE_KRB5_FREE_UNPARSED_NAME 

'' Define to 1 if you have the `krb5_get_default_in_tkt_etypes' function. 
'' #undef HAVE_KRB5_GET_DEFAULT_IN_TKT_ETYPES 

'' Define to 1 if you have the `krb5_get_init_creds_opt_set_pac_request'
''   function. 
'' #undef HAVE_KRB5_GET_INIT_CREDS_OPT_SET_PAC_REQUEST 

'' Define to 1 if you have the `krb5_get_kdc_cred' function. 
'' #undef HAVE_KRB5_GET_KDC_CRED 

'' Define to 1 if you have the `krb5_get_permitted_enctypes' function. 
'' #undef HAVE_KRB5_GET_PERMITTED_ENCTYPES 

'' Define to 1 if you have the `krb5_get_pw_salt' function. 
'' #undef HAVE_KRB5_GET_PW_SALT 

'' Define to 1 if you have the `krb5_get_renewed_creds' function. 
'' #undef HAVE_KRB5_GET_RENEWED_CREDS 

'' Define to 1 if you have the <krb5.h> header file. 
'' #undef HAVE_KRB5_H 

'' Whether the krb5_creds struct has a keyblock property 
'' #undef HAVE_KRB5_KEYBLOCK_IN_CREDS 

'' Whether the krb5_keyblock struct has a keyvalue property 
'' #undef HAVE_KRB5_KEYBLOCK_KEYVALUE 

'' Whether krb5_keytab_entry has key member 
'' #undef HAVE_KRB5_KEYTAB_ENTRY_KEY 

'' Whether krb5_keytab_entry has keyblock member 
'' #undef HAVE_KRB5_KEYTAB_ENTRY_KEYBLOCK 

'' Whether KRB5_KEYUSAGE_APP_DATA_CKSUM is available 
'' #undef HAVE_KRB5_KEYUSAGE_APP_DATA_CKSUM 

'' Define to 1 if you have the `krb5_krbhst_get_addrinfo' function. 
'' #undef HAVE_KRB5_KRBHST_GET_ADDRINFO 

'' Define to 1 if you have the `krb5_kt_compare' function. 
'' #undef HAVE_KRB5_KT_COMPARE 

'' Define to 1 if you have the `krb5_kt_free_entry' function. 
'' #undef HAVE_KRB5_KT_FREE_ENTRY 

'' Whether KRB5_KU_OTHER_CKSUM is available 
'' #undef HAVE_KRB5_KU_OTHER_CKSUM 

'' Define to 1 if you have the `krb5_locate_kdc' function. 
'' #undef HAVE_KRB5_LOCATE_KDC 

'' Define to 1 if you have the `krb5_mk_req_extended' function. 
'' #undef HAVE_KRB5_MK_REQ_EXTENDED 

'' Define to 1 if you have the `krb5_parse_name_norealm' function. 
'' #undef HAVE_KRB5_PARSE_NAME_NOREALM 

'' Define to 1 if you have the `krb5_principal2salt' function. 
'' #undef HAVE_KRB5_PRINCIPAL2SALT 

'' Define to 1 if you have the `krb5_principal_compare_any_realm' function. 
'' #undef HAVE_KRB5_PRINCIPAL_COMPARE_ANY_REALM 

'' Define to 1 if you have the `krb5_principal_get_comp_string' function. 
'' #undef HAVE_KRB5_PRINCIPAL_GET_COMP_STRING 

'' Whether krb5_princ_component is available 
'' #undef HAVE_KRB5_PRINC_COMPONENT 

'' Define to 1 if you have the `krb5_princ_size' function. 
'' #undef HAVE_KRB5_PRINC_SIZE 

'' Whether the krb5_creds struct has a session property 
'' #undef HAVE_KRB5_SESSION_IN_CREDS 

'' Define to 1 if you have the `krb5_set_default_in_tkt_etypes' function. 
'' #undef HAVE_KRB5_SET_DEFAULT_IN_TKT_ETYPES 

'' Define to 1 if you have the `krb5_set_default_tgs_ktypes' function. 
'' #undef HAVE_KRB5_SET_DEFAULT_TGS_KTYPES 

'' Define to 1 if you have the `krb5_set_real_time' function. 
'' #undef HAVE_KRB5_SET_REAL_TIME 

'' Define to 1 if you have the `krb5_string_to_key' function. 
'' #undef HAVE_KRB5_STRING_TO_KEY 

'' Define to 1 if you have the `krb5_string_to_key_salt' function. 
'' #undef HAVE_KRB5_STRING_TO_KEY_SALT 

'' Whether the krb5_ticket struct has a enc_part2 property 
'' #undef HAVE_KRB5_TKT_ENC_PART2 

'' Define to 1 if you have the `krb5_use_enctype' function. 
'' #undef HAVE_KRB5_USE_ENCTYPE 

'' Whether the KV5M_KEYTAB option is available 
'' #undef HAVE_KV5M_KEYTAB 

'' Define to 1 if you have the <langinfo.h> header file. 
'' #undef HAVE_LANGINFO_H 

'' Define to 1 if you have the <lastlog.h> header file. 
'' #undef HAVE_LASTLOG_H 

'' Define to 1 if you have the <lber.h> header file. 
'' #undef HAVE_LBER_H 

'' Whether ldap is available 
'' #undef HAVE_LDAP 

'' Define to 1 if you have the `ldap_add_result_entry' function. 
'' #undef HAVE_LDAP_ADD_RESULT_ENTRY 

'' Define to 1 if you have the `ldap_dn2ad_canonical' function. 
'' #undef HAVE_LDAP_DN2AD_CANONICAL 

'' Define to 1 if you have the <ldap.h> header file. 
'' #undef HAVE_LDAP_H 

'' Define to 1 if you have the `ldap_init' function. 
'' #undef HAVE_LDAP_INIT 

'' Define to 1 if you have the `ldap_initialize' function. 
'' #undef HAVE_LDAP_INITIALIZE 

'' Define to 1 if you have the `ldap_set_rebind_proc' function. 
'' #undef HAVE_LDAP_SET_REBIND_PROC 

'' Define to 1 if you have the `lgetea' function. 
'' #undef HAVE_LGETEA 

'' Define to 1 if you have the `lgetxattr' function. 
'' #undef HAVE_LGETXATTR 

'' Define to 1 if you have the `asn1' library (-lasn1). 
'' #undef HAVE_LIBASN1 

'' Define to 1 if you have the `com_err' library (-lcom_err). 
'' #undef HAVE_LIBCOM_ERR 

'' Define to 1 if you have the `crypto' library (-lcrypto). 
'' #undef HAVE_LIBCRYPTO 

'' Define to 1 if you have the `dl' library (-ldl). 
'' #undef HAVE_LIBDL 

'' Define to 1 if you have the `exc' library (-lexc). 
'' #undef HAVE_LIBEXC 

'' Define to 1 if you have the <libexc.h> header file. 
'' #undef HAVE_LIBEXC_H 

'' Define to 1 if you have the `fam' library (-lfam). 
'' #undef HAVE_LIBFAM 

'' Define to 1 if you have the `gssapi' library (-lgssapi). 
'' #undef HAVE_LIBGSSAPI 

'' Define to 1 if you have the `gssapi_krb5' library (-lgssapi_krb5). 
'' #undef HAVE_LIBGSSAPI_KRB5 

'' Define to 1 if you have the `inet' library (-linet). 
'' #undef HAVE_LIBINET 

'' Define to 1 if you have the `k5crypto' library (-lk5crypto). 
'' #undef HAVE_LIBK5CRYPTO 

'' Define to 1 if you have the `krb5' library (-lkrb5). 
'' #undef HAVE_LIBKRB5 

'' Define to 1 if you have the `lber' library (-llber). 
'' #undef HAVE_LIBLBER 

'' Define to 1 if you have the `ldap' library (-lldap). 
'' #undef HAVE_LIBLDAP 

'' Define to 1 if you have the `nscd' library (-lnscd). 
'' #undef HAVE_LIBNSCD 

'' Define to 1 if you have the `nsl' library (-lnsl). 
'' #undef HAVE_LIBNSL 

'' Define to 1 if you have the `nsl_s' library (-lnsl_s). 
'' #undef HAVE_LIBNSL_S 

'' Whether libpam is available 
'' #undef HAVE_LIBPAM 

'' Whether the system has readline 
'' #undef HAVE_LIBREADLINE 

'' Define to 1 if you have the `resolv' library (-lresolv). 
'' #undef HAVE_LIBRESOLV 

'' Define to 1 if you have the `roken' library (-lroken). 
'' #undef HAVE_LIBROKEN 

'' Define to 1 if you have the `sendfile' library (-lsendfile). 
'' #undef HAVE_LIBSENDFILE 

'' Define to 1 if you have the `socket' library (-lsocket). 
'' #undef HAVE_LIBSOCKET 

'' Whether libunwind is available 
'' #undef HAVE_LIBUNWIND 

'' Define to 1 if you have the <libunwind.h> header file. 
'' #undef HAVE_LIBUNWIND_H 

'' Whether libunwind-ptrace.a is available. 
'' #undef HAVE_LIBUNWIND_PTRACE 

'' Define to 1 if you have the <libunwind-ptrace.h> header file. 
'' #undef HAVE_LIBUNWIND_PTRACE_H 

'' Define to 1 if you have the <limits.h> header file. 
'#Const HAVE_LIMITS_H = True

'' Define to 1 if you have the `link' function. 
'' #undef HAVE_LINK 

'' Whether the Linux ptrace(2) interface is available. 
'' #undef HAVE_LINUX_PTRACE 

'' Whether Linux xfs quota support is available 
'' #undef HAVE_LINUX_XFS_QUOTAS 

'' Define to 1 if you have the `listea' function. 
'' #undef HAVE_LISTEA 

'' Define to 1 if you have the `listxattr' function. 
'' #undef HAVE_LISTXATTR 

'' Define to 1 if you have the `llistea' function. 
'' #undef HAVE_LLISTEA 

'' Define to 1 if you have the `llistxattr' function. 
'' #undef HAVE_LLISTXATTR 

'' Define to 1 if you have the `llseek' function. 
'' #undef HAVE_LLSEEK 

'' Define to 1 if you have the <locale.h> header file. 
'#Const HAVE_LOCALE_H = True

'' Whether the host supports long long's 
'#Const HAVE_LONGLONG = True

'' Define to 1 if you have the `lremoveea' function. 
'' #undef HAVE_LREMOVEEA 

'' Define to 1 if you have the `lremovexattr' function. 
'' #undef HAVE_LREMOVEXATTR 

'' Define to 1 if you have the `lseek64' function. 
'#Const HAVE_LSEEK64 = True

'' Define to 1 if you have the `lsetea' function. 
'' #undef HAVE_LSETEA 

'' Define to 1 if you have the `lsetxattr' function. 
'' #undef HAVE_LSETXATTR 

'' Define to 1 if you have the `lstat64' function. 
'' #undef HAVE_LSTAT64 

'' Whether the krb5_address struct has a magic property 
'' #undef HAVE_MAGIC_IN_KRB5_ADDRESS 

'' Whether the macro for makedev is available 
'' #undef HAVE_MAKEDEV 

'' Define to 1 if you have the `memmove' function. 
'#Const HAVE_MEMMOVE = True

'' Define to 1 if you have the <memory.h> header file. 
'#Const HAVE_MEMORY_H = True

'' Whether memset() is available 
'#Const HAVE_MEMSET = True

'' Define to 1 if you have the `mknod' function. 
'' #undef HAVE_MKNOD 

'' Define to 1 if you have the `mknod64' function. 
'' #undef HAVE_MKNOD64 

'' Define to 1 if you have the `mktime' function. 
'#Const HAVE_MKTIME = True

'' Define to 1 if you have the `mlock' function. 
'' #undef HAVE_MLOCK 

'' Define to 1 if you have the `mlockall' function. 
'' #undef HAVE_MLOCKALL 

'' Whether mmap works 
'' #undef HAVE_MMAP 

'' Define to 1 if you have the <mntent.h> header file. 
'' #undef HAVE_MNTENT_H 

'' Define to 1 if you have the `munlock' function. 
'' #undef HAVE_MUNLOCK 

'' Define to 1 if you have the `munlockall' function. 
'' #undef HAVE_MUNLOCKALL 

'' Define to 1 if you have the `nanosleep' function. 
'' #undef HAVE_NANOSLEEP 

'' Whether to use native iconv 
'#Const HAVE_NATIVE_ICONV = True

'' Define to 1 if you have the <ndir.h> header file, and it defines `DIR'. 
'' #undef HAVE_NDIR_H 

'' Define to 1 if you have the <netinet/in_ip.h> header file. 
'' #undef HAVE_NETINET_IN_IP_H 

'' Define to 1 if you have the <netinet/in_systm.h> header file. 
'' #undef HAVE_NETINET_IN_SYSTM_H 

'' Define to 1 if you have the <netinet/ip.h> header file. 
'' #undef HAVE_NETINET_IP_H 

'' Define to 1 if you have the <netinet/tcp.h> header file. 
'' #undef HAVE_NETINET_TCP_H 

'' Define to 1 if you have the <net/if.h> header file. 
'' #undef HAVE_NET_IF_H 

'' Do we have rl_completion_matches? 
'' #undef HAVE_NEW_LIBREADLINE 

'' Define to 1 if you have the `nl_langinfo' function. 
'' #undef HAVE_NL_LANGINFO 

'' Whether no ACLs support is available 
'#Const HAVE_NO_ACLS = True

'' Whether no asynchronous io support is available 
'#Const HAVE_NO_AIO = True

'' Define to 1 if you have the `nscd_flush_cache' function. 
'' #undef HAVE_NSCD_FLUSH_CACHE 

'' Define to 1 if you have the <nsswitch.h> header file. 
'' #undef HAVE_NSSWITCH_H 

'' Define to 1 if you have the <nss_common.h> header file. 
'' #undef HAVE_NSS_COMMON_H 

'' Define to 1 if you have the <nss.h> header file. 
'' #undef HAVE_NSS_H 

'' Defined if union nss_XbyY_key has ipnode field 
'' #undef HAVE_NSS_XBYY_KEY_IPNODE 

'' Define to 1 if you have the <ns_api.h> header file. 
'' #undef HAVE_NS_API_H 

'' Whether off64_t is available 
'#Const HAVE_OFF64_T = True

'' Define to 1 if you have the `open64' function. 
'' #undef HAVE_OPEN64 

'' Define to 1 if you have the `opendir64' function. 
'' #undef HAVE_OPENDIR64 

'' Defined if struct passwd has pw_age field 
'' #undef HAVE_PASSWD_PW_AGE 

'' Defined if struct passwd has pw_comment field 
'' #undef HAVE_PASSWD_PW_COMMENT 

'' Define to 1 if you have the `pathconf' function. 
'' #undef HAVE_PATHCONF 

'' Define to 1 if you have the `pipe' function. 
'' #undef HAVE_PIPE 

'' Define to 1 if you have the `poll' function. 
'' #undef HAVE_POLL 

'' Define to 1 if you have the <poll.h> header file. 
'' #undef HAVE_POLL_H 

'' Whether POSIX ACLs are available 
'' #undef HAVE_POSIX_ACLS 

'' Whether POSIX capabilities are available 
'' #undef HAVE_POSIX_CAPABILITIES 

'' Whether prctl is available 
'' #undef HAVE_PRCTL 

'' Define to 1 if you have the `pread' function. 
'' #undef HAVE_PREAD 

'' Define to 1 if you have the `pread64' function. 
'' #undef HAVE_PREAD64 

'' Whether putprpwnam is available 
'' #undef HAVE_PUTPRPWNAM 

'' Define to 1 if you have the `pututline' function. 
'' #undef HAVE_PUTUTLINE 

'' Define to 1 if you have the `pututxline' function. 
'' #undef HAVE_PUTUTXLINE 

'' Define to 1 if you have the `pwrite' function. 
'' #undef HAVE_PWRITE 

'' Define to 1 if you have the `pwrite64' function. 
'' #undef HAVE_PWRITE64 

'' Whether CRAY int quotactl (char *spec, int request, char *arg); is
''   available 
'' #undef HAVE_QUOTACTL_3 

'' Whether long quotactl(int cmd, char *special, qid_t id, caddr_t addr) is
''   available 
'' #undef HAVE_QUOTACTL_4A 

'' Whether int quotactl(const char *path, int cmd, int id, char *addr) is
''   available 
'' #undef HAVE_QUOTACTL_4B 

'' Whether Linux quota support is available 
'' #undef HAVE_QUOTACTL_LINUX 

'' Define to 1 if you have the `rand' function. 
'#Const HAVE_RAND = True

'' Define to 1 if you have the `random' function. 
'' #undef HAVE_RANDOM 

'' Define to 1 if you have the `rdchk' function. 
'' #undef HAVE_RDCHK 

'' Define to 1 if you have the `readdir64' function. 
'' #undef HAVE_READDIR64 

'' Define to 1 if you have the <readline.h> header file. 
'' #undef HAVE_READLINE_H 

'' Define to 1 if you have the <readline/history.h> header file. 
'' #undef HAVE_READLINE_HISTORY_H 

'' Define to 1 if you have the <readline/readline.h> header file. 
'' #undef HAVE_READLINE_READLINE_H 

'' Define to 1 if you have the `readlink' function. 
'' #undef HAVE_READLINK 

'' Define to 1 if you have the `realpath' function. 
'' #undef HAVE_REALPATH 

'' Define to 1 if you have the `removeea' function. 
'' #undef HAVE_REMOVEEA 

'' Define to 1 if you have the `removexattr' function. 
'' #undef HAVE_REMOVEXATTR 

'' Define to 1 if you have the `rename' function. 
'#Const HAVE_RENAME = True

'' Define to 1 if you have the `rewinddir64' function. 
'' #undef HAVE_REWINDDIR64 

'' Define to 1 if you have the `roken_getaddrinfo_hostspec' function. 
'' #undef HAVE_ROKEN_GETADDRINFO_HOSTSPEC 

'' Whether current user is root 
'#Const HAVE_ROOT = True

'' Define to 1 if you have the <rpcsvc/nis.h> header file. 
'' #undef HAVE_RPCSVC_NIS_H 

'' Define to 1 if you have the <rpcsvc/ypclnt.h> header file. 
'' #undef HAVE_RPCSVC_YPCLNT_H 

'' Define to 1 if you have the <rpcsvc/yp_prot.h> header file. 
'' #undef HAVE_RPCSVC_YP_PROT_H 

'' Whether there is a conflicting AUTH_ERROR define in rpc/rpc.h 
'' #undef HAVE_RPC_AUTH_ERROR_CONFLICT 

'' Define to 1 if you have the <rpc/nettype.h> header file. 
'' #undef HAVE_RPC_NETTYPE_H 

'' Define to 1 if you have the <rpc/rpc.h> header file. 
'' #undef HAVE_RPC_RPC_H 

'' Whether mkstemp is secure 
'' #undef HAVE_SECURE_MKSTEMP 

'' Define to 1 if you have the <security/pam_appl.h> header file. 
'' #undef HAVE_SECURITY_PAM_APPL_H 

'' Define to 1 if you have the <security/pam_modules.h> header file. 
'' #undef HAVE_SECURITY_PAM_MODULES_H 

'' Define to 1 if you have the <security/_pam_macros.h> header file. 
'' #undef HAVE_SECURITY__PAM_MACROS_H 

'' Define to 1 if you have the `seekdir64' function. 
'' #undef HAVE_SEEKDIR64 

'' Define to 1 if you have the `select' function. 
'#Const HAVE_SELECT = True

'' Whether sendfile() is available 
'' #undef HAVE_SENDFILE 

'' Whether sendfile64() is available 
'' #undef HAVE_SENDFILE64 

'' Whether sendfilev() is available 
'' #undef HAVE_SENDFILEV 

'' Whether sendfilev64() is available 
'' #undef HAVE_SENDFILEV64 

'' Define to 1 if you have the `setbuffer' function. 
'' #undef HAVE_SETBUFFER 

'' Define to 1 if you have the `setea' function. 
'' #undef HAVE_SETEA 

'' Define to 1 if you have the `setenv' function. 
'' #undef HAVE_SETENV 

'' Define to 1 if you have the `setgidx' function. 
'' #undef HAVE_SETGIDX 

'' Define to 1 if you have the `setgroups' function. 
'' #undef HAVE_SETGROUPS 

'' Define to 1 if you have the `setlinebuf' function. 
'' #undef HAVE_SETLINEBUF 

'' Define to 1 if you have the `setlocale' function. 
'#Const HAVE_SETLOCALE = True

'' Define to 1 if you have the `setluid' function. 
'' #undef HAVE_SETLUID 

'' Define to 1 if you have the `setmntent' function. 
'' #undef HAVE_SETMNTENT 

'' Define to 1 if you have the `setnetgrent' function. 
'' #undef HAVE_SETNETGRENT 

'' Define to 1 if you have the `setpgid' function. 
'' #undef HAVE_SETPGID 

'' Define to 1 if you have the `setpriv' function. 
'' #undef HAVE_SETPRIV 

'' Define to 1 if you have the `setproplist' function. 
'' #undef HAVE_SETPROPLIST 

'' Whether the system has setresgid 
'' #undef HAVE_SETRESGID 

'' Whether setresgid() is available 
'' #undef HAVE_SETRESGID_DECL 

'' Whether the system has setresuid 
'' #undef HAVE_SETRESUID 

'' Whether setresuid() is available 
'' #undef HAVE_SETRESUID_DECL 

'' Define to 1 if you have the `setsid' function. 
'' #undef HAVE_SETSID 

'' Define to 1 if you have the `setuidx' function. 
'' #undef HAVE_SETUIDX 

'' Define to 1 if you have the `setxattr' function. 
'' #undef HAVE_SETXATTR 

'' Whether set_auth_parameters is available 
'' #undef HAVE_SET_AUTH_PARAMETERS 

'' Define to 1 if you have the <shadow.h> header file. 
'' #undef HAVE_SHADOW_H 

'' Define to 1 if you have the `shmget' function. 
'' #undef HAVE_SHMGET 

'' Define to 1 if you have the `shm_open' function. 
'' #undef HAVE_SHM_OPEN 

'' Define to 1 if you have the `sigaction' function. 
'' #undef HAVE_SIGACTION 

'' Define to 1 if you have the `sigblock' function. 
'' #undef HAVE_SIGBLOCK 

'' Define to 1 if you have the `sigprocmask' function. 
'' #undef HAVE_SIGPROCMASK 

'' Define to 1 if you have the `sigset' function. 
'' #undef HAVE_SIGSET 

'' Whether we have the atomic_t variable type 
'#Const HAVE_SIG_ATOMIC_T_TYPE = True

'' Define to 1 if you have the `sizeof_proplist_entry' function. 
'' #undef HAVE_SIZEOF_PROPLIST_ENTRY 

'' Define to 1 if you have the `snprintf' function. 
'#Const HAVE_SNPRINTF = True

'' Whether snprintf() is available 
'#Const HAVE_SNPRINTF_DECL = True

'' Whether we have the variable type socklen_t 
'' #undef HAVE_SOCKLEN_T_TYPE 

'' Whether the sockaddr_in struct has a sin_len property 
'' #undef HAVE_SOCK_SIN_LEN 

'' Whether solaris ACLs are available 
'' #undef HAVE_SOLARIS_ACLS 

'' Define to 1 if you have the `srand' function. 
'#Const HAVE_SRAND = True

'' Define to 1 if you have the `srandom' function. 
'' #undef HAVE_SRANDOM 

'' Whether stat64() is available 
'#Const HAVE_STAT64 = True

'' whether struct stat has sub-second timestamps without struct timespec 
'' #undef HAVE_STAT_HIRES_TIMESTAMPS 

'' whether struct stat contains st_atim 
'#Const HAVE_STAT_ST_ATIM = True

'' whether struct stat contains st_atimensec 
'' #undef HAVE_STAT_ST_ATIMENSEC 

'' Whether the stat struct has a st_blksize property 
'' #undef HAVE_STAT_ST_BLKSIZE 

'' Whether the stat struct has a st_block property 
'' #undef HAVE_STAT_ST_BLOCKS 

'' whether struct stat contains st_ctim 
'#Const HAVE_STAT_ST_CTIM = True

'' whether struct stat contains st_ctimensec 
'' #undef HAVE_STAT_ST_CTIMENSEC 

'' whether struct stat contains st_mtim 
'#Const HAVE_STAT_ST_MTIM = True

'' whether struct stat contains st_mtimensec 
'' #undef HAVE_STAT_ST_MTIMENSEC 

'' Define to 1 if you have the <stdarg.h> header file. 
'#Const HAVE_STDARG_H = True

'' Define to 1 if you have the <stdint.h> header file. 
'' #undef HAVE_STDINT_H 

'' Define to 1 if you have the <stdlib.h> header file. 
'#Const HAVE_STDLIB_H = True

'' Define to 1 if you have the `strcasecmp' function. 
'#Const HAVE_STRCASECMP = True

'' Define to 1 if you have the `strchr' function. 
'#Const HAVE_STRCHR = True

'' Define to 1 if you have the `strdup' function. 
'#Const HAVE_STRDUP = True

'' Define to 1 if you have the `strerror' function. 
'#Const HAVE_STRERROR = True

'' Define to 1 if you have the `strftime' function. 
'#Const HAVE_STRFTIME = True

'' Define to 1 if you have the <strings.h> header file. 
'' #undef HAVE_STRINGS_H 

'' Define to 1 if you have the <string.h> header file. 
'#Const HAVE_STRING_H = True

'' Define to 1 if you have the `strlcat' function. 
'' #undef HAVE_STRLCAT 

'' Define to 1 if you have the `strlcpy' function. 
'' #undef HAVE_STRLCPY 

'' Define to 1 if you have the `strndup' function. 
'' #undef HAVE_STRNDUP 

'' Define to 1 if you have the `strnlen' function. 
'' #undef HAVE_STRNLEN 

'' Define to 1 if you have the <stropts.h> header file. 
'' #undef HAVE_STROPTS_H 

'' Define to 1 if you have the `strpbrk' function. 
'#Const HAVE_STRPBRK = True

'' Define to 1 if you have the `strsignal' function. 
'' #undef HAVE_STRSIGNAL 

'' Define to 1 if you have the `strtoul' function. 
'#Const HAVE_STRTOUL = True

'' Whether the 'DIR64' abstract data type is available 
'' #undef HAVE_STRUCT_DIR64 

'' Whether the 'dirent64' struct is available 
'' #undef HAVE_STRUCT_DIRENT64 

'' Whether the flock64 struct is available 
'' #undef HAVE_STRUCT_FLOCK64 

'' Define to 1 if `method_attrlist' is member of `struct secmethod_table'. 
'' #undef HAVE_STRUCT_SECMETHOD_TABLE_METHOD_ATTRLIST 

'' Define to 1 if `method_version' is member of `struct secmethod_table'. 
'' #undef HAVE_STRUCT_SECMETHOD_TABLE_METHOD_VERSION 

'' Define to 1 if `st_rdev' is member of `struct stat'. 
'#Const HAVE_STRUCT_STAT_ST_RDEV = True

'' Whether we have struct timespec 
'' #undef HAVE_STRUCT_TIMESPEC 

'' Define to 1 if your `struct stat' has `st_rdev'. Deprecated, use
''   `HAVE_STRUCT_STAT_ST_RDEV' instead. 
'#Const HAVE_ST_RDEV = True

'' Define to 1 if you have the `symlink' function. 
'' #undef HAVE_SYMLINK 

'' Define to 1 if you have the `syscall' function. 
'' #undef HAVE_SYSCALL 

'' Define to 1 if you have the <syscall.h> header file. 
'' #undef HAVE_SYSCALL_H 

'' Define to 1 if you have the `sysconf' function. 
'' #undef HAVE_SYSCONF 

'' Define to 1 if you have the `syslog' function. 
'' #undef HAVE_SYSLOG 

'' Define to 1 if you have the <syslog.h> header file. 
'' #undef HAVE_SYSLOG_H 

'' Define to 1 if you have the <sys/acl.h> header file. 
'' #undef HAVE_SYS_ACL_H 

'' Define to 1 if you have the <sys/attributes.h> header file. 
'' #undef HAVE_SYS_ATTRIBUTES_H 

'' Whether sys/capability.h is present 
'' #undef HAVE_SYS_CAPABILITY_H 

'' Define to 1 if you have the <sys/cdefs.h> header file. 
'' #undef HAVE_SYS_CDEFS_H 

'' Define to 1 if you have the <sys/dir.h> header file, and it defines `DIR'.
''   
'' #undef HAVE_SYS_DIR_H 

'' Define to 1 if you have the <sys/dmapi.h> header file. 
'' #undef HAVE_SYS_DMAPI_H 

'' Define to 1 if you have the <sys/dmi.h> header file. 
'' #undef HAVE_SYS_DMI_H 

'' Define to 1 if you have the <sys/dustat.h> header file. 
'' #undef HAVE_SYS_DUSTAT_H 

'' Define to 1 if you have the <sys/ea.h> header file. 
'' #undef HAVE_SYS_EA_H 

'' Define to 1 if you have the <sys/extattr.h> header file. 
'' #undef HAVE_SYS_EXTATTR_H 

'' Define to 1 if you have the <sys/fcntl.h> header file. 
'' #undef HAVE_SYS_FCNTL_H 

'' Define to 1 if you have the <sys/filio.h> header file. 
'' #undef HAVE_SYS_FILIO_H 

'' Define to 1 if you have the <sys/filsys.h> header file. 
'' #undef HAVE_SYS_FILSYS_H 

'' Define to 1 if you have the <sys/fs/s5param.h> header file. 
'' #undef HAVE_SYS_FS_S5PARAM_H 

'' Define to 1 if you have the <sys/fs/vx_quota.h> header file. 
'' #undef HAVE_SYS_FS_VX_QUOTA_H 

'' Define to 1 if you have the <sys/id.h> header file. 
'' #undef HAVE_SYS_ID_H 

'' Define to 1 if you have the <sys/ioctl.h> header file. 
'' #undef HAVE_SYS_IOCTL_H 

'' Define to 1 if you have the <sys/ipc.h> header file. 
'' #undef HAVE_SYS_IPC_H 

'' Define to 1 if you have the <sys/jfsdmapi.h> header file. 
'' #undef HAVE_SYS_JFSDMAPI_H 

'' Define to 1 if you have the <sys/mman.h> header file. 
'' #undef HAVE_SYS_MMAN_H 

'' Define to 1 if you have the <sys/mode.h> header file. 
'' #undef HAVE_SYS_MODE_H 

'' Define to 1 if you have the <sys/mount.h> header file. 
'' #undef HAVE_SYS_MOUNT_H 

'' Define to 1 if you have the <sys/ndir.h> header file, and it defines `DIR'.
''   
'' #undef HAVE_SYS_NDIR_H 

'' Define to 1 if you have the <sys/param.h> header file. 
'' #undef HAVE_SYS_PARAM_H 

'' Define to 1 if you have the <sys/prctl.h> header file. 
'' #undef HAVE_SYS_PRCTL_H 

'' Define to 1 if you have the <sys/priv.h> header file. 
'' #undef HAVE_SYS_PRIV_H 

'' Define to 1 if you have the <sys/proplist.h> header file. 
'' #undef HAVE_SYS_PROPLIST_H 

'' Define to 1 if you have the <sys/ptrace.h> header file. 
'' #undef HAVE_SYS_PTRACE_H 

'' Whether the new lib/sysquotas.c interface can be used 
'' #undef HAVE_SYS_QUOTAS 

'' Define to 1 if you have the <sys/quota.h> header file. 
'' #undef HAVE_SYS_QUOTA_H 

'' Define to 1 if you have the <sys/resource.h> header file. 
'' #undef HAVE_SYS_RESOURCE_H 

'' Define to 1 if you have the <sys/security.h> header file. 
'' #undef HAVE_SYS_SECURITY_H 

'' Define to 1 if you have the <sys/select.h> header file. 
'' #undef HAVE_SYS_SELECT_H 

'' Define to 1 if you have the <sys/shm.h> header file. 
'' #undef HAVE_SYS_SHM_H 

'' Define to 1 if you have the <sys/socket.h> header file. 
'' #undef HAVE_SYS_SOCKET_H 

'' Define to 1 if you have the <sys/sockio.h> header file. 
'' #undef HAVE_SYS_SOCKIO_H 

'' Define to 1 if you have the <sys/statfs.h> header file. 
'' #undef HAVE_SYS_STATFS_H 

'' Define to 1 if you have the <sys/statvfs.h> header file. 
'' #undef HAVE_SYS_STATVFS_H 

'' Define to 1 if you have the <sys/stat.h> header file. 
'#Const HAVE_SYS_STAT_H = True

'' Define to 1 if you have the <sys/syscall.h> header file. 
'' #undef HAVE_SYS_SYSCALL_H 

'' Define to 1 if you have the <sys/syslog.h> header file. 
'' #undef HAVE_SYS_SYSLOG_H 

'' Define to 1 if you have the <sys/sysmacros.h> header file. 
'' #undef HAVE_SYS_SYSMACROS_H 

'' Define to 1 if you have the <sys/termio.h> header file. 
'' #undef HAVE_SYS_TERMIO_H 

'' Define to 1 if you have the <sys/time.h> header file. 
'' #undef HAVE_SYS_TIME_H 

'' Define to 1 if you have the <sys/types.h> header file. 
'#Const HAVE_SYS_TYPES_H = True

'' Define to 1 if you have the <sys/uio.h> header file. 
'' #undef HAVE_SYS_UIO_H 

'' Define to 1 if you have the <sys/unistd.h> header file. 
'' #undef HAVE_SYS_UNISTD_H 

'' Define to 1 if you have the <sys/un.h> header file. 
'' #undef HAVE_SYS_UN_H 

'' Define to 1 if you have the <sys/vfs.h> header file. 
'' #undef HAVE_SYS_VFS_H 

'' Define to 1 if you have the <sys/wait.h> header file. 
'' #undef HAVE_SYS_WAIT_H 

'' Define to 1 if you have the <sys/xattr.h> header file. 
'' #undef HAVE_SYS_XATTR_H 

'' Define to 1 if you have the `telldir64' function. 
'' #undef HAVE_TELLDIR64 

'' Define to 1 if you have the <termios.h> header file. 
'' #undef HAVE_TERMIOS_H 

'' Define to 1 if you have the <termio.h> header file. 
'' #undef HAVE_TERMIO_H 

'' Whether the krb5_ap_req struct has a ticket pointer 
'' #undef HAVE_TICKET_POINTER_IN_KRB5_AP_REQ 

'' Define to 1 if you have the `timegm' function. 
'' #undef HAVE_TIMEGM 

'' Whether Tru64 ACLs are available 
'' #undef HAVE_TRU64_ACLS 

'' Whether crypt needs truncated salt 
'' #undef HAVE_TRUNCATED_SALT 

'' Whether uint16 typedef is included by rpc/rpc.h 
'' #undef HAVE_UINT16_FROM_RPC_RPC_H 

'' Whether uint32 typedef is included by rpc/rpc.h 
'' #undef HAVE_UINT32_FROM_RPC_RPC_H 

'' Define to 1 if you have the <unistd.h> header file. 
'' #undef HAVE_UNISTD_H 

'' If we need to build with unixscoket support 
'' #undef HAVE_UNIXSOCKET 

'' Whether UnixWare ACLs are available 
'' #undef HAVE_UNIXWARE_ACLS 

'' Whether the 'unsigned char' type is available 
'#Const HAVE_UNSIGNED_CHAR = True

'' Define to 1 if you have the `updwtmp' function. 
'' #undef HAVE_UPDWTMP 

'' Define to 1 if you have the `updwtmpx' function. 
'' #undef HAVE_UPDWTMPX 

'' Define to 1 if you have the `usleep' function. 
'' #undef HAVE_USLEEP 

'' Whether struct utimbuf is available 
'#Const HAVE_UTIMBUF = True

'' Define to 1 if you have the `utime' function. 
'#Const HAVE_UTIME = True

'' Define to 1 if you have the `utimes' function. 
'' #undef HAVE_UTIMES 

'' Define to 1 if you have the <utime.h> header file. 
'' #undef HAVE_UTIME_H 

'' Define to 1 if you have the <utmpx.h> header file. 
'' #undef HAVE_UTMPX_H 

'' Define to 1 if you have the <utmp.h> header file. 
'' #undef HAVE_UTMP_H 

'' Whether the utmp struct has a property ut_addr 
'' #undef HAVE_UT_UT_ADDR 

'' Whether the utmp struct has a property ut_exit 
'' #undef HAVE_UT_UT_EXIT 

'' Whether the utmp struct has a property ut_host 
'' #undef HAVE_UT_UT_HOST 

'' Whether the utmp struct has a property ut_id 
'' #undef HAVE_UT_UT_ID 

'' Whether the utmp struct has a property ut_name 
'' #undef HAVE_UT_UT_NAME 

'' Whether the utmp struct has a property ut_pid 
'' #undef HAVE_UT_UT_PID 

'' Whether the utmp struct has a property ut_time 
'' #undef HAVE_UT_UT_TIME 

'' Whether the utmp struct has a property ut_tv 
'' #undef HAVE_UT_UT_TV 

'' Whether the utmp struct has a property ut_type 
'' #undef HAVE_UT_UT_TYPE 

'' Whether the utmp struct has a property ut_user 
'' #undef HAVE_UT_UT_USER 

'' Whether the utmpx struct has a property ut_syslen 
'' #undef HAVE_UX_UT_SYSLEN 

'' Define to 1 if you have the <valgrind.h> header file. 
'' #undef HAVE_VALGRIND_H 

'' Define to 1 if you have the <valgrind/memcheck.h> header file. 
'' #undef HAVE_VALGRIND_MEMCHECK_H 

'' Define to 1 if you have the <valgrind/valgrind.h> header file. 
'' #undef HAVE_VALGRIND_VALGRIND_H 

'' Define to 1 if you have the `vasprintf' function. 
'' #undef HAVE_VASPRINTF 

'' Whether vasprintf() is available 
'' #undef HAVE_VASPRINTF_DECL 

'' Whether va_copy() is available 
'' #undef HAVE_VA_COPY 

'' Whether the C compiler understands volatile 
'' #undef HAVE_VOLATILE 

'' Define to 1 if you have the `vsnprintf' function. 
'#Const HAVE_VSNPRINTF = True

'' Whether vsnprintf() is available 
'#Const HAVE_VSNPRINTF_DECL = True

'' Define to 1 if you have the `vsyslog' function. 
'' #undef HAVE_VSYSLOG 

'' Define to 1 if you have the `waitpid' function. 
'#Const HAVE_WAITPID = True

'' Define if you have working AF_LOCAL sockets 
'' #undef HAVE_WORKING_AF_LOCAL 

'' Whether the WRFILE:-keytab is supported 
'' #undef HAVE_WRFILE_KEYTAB 

'' Define to 1 if you have the <xfs/dmapi.h> header file. 
'' #undef HAVE_XFS_DMAPI_H 

'' Whether xfs quota support is available 
'' #undef HAVE_XFS_QUOTAS 

'' Define to 1 if you have the `yp_get_default_domain' function. 
'' #undef HAVE_YP_GET_DEFAULT_DOMAIN 

'' Define to 1 if you have the `_acl' function. 
'' #undef HAVE__ACL 

'' Define to 1 if you have the `_chdir' function. 
'#Const HAVE__CHDIR = True

'' Define to 1 if you have the `_close' function. 
'#Const HAVE__CLOSE = True

'' Define to 1 if you have the `_closedir' function. 
'' #undef HAVE__CLOSEDIR 

'' Define to 1 if you have the `_dup' function. 
'#Const HAVE__DUP = True

'' Define to 1 if you have the `_dup2' function. 
'#Const HAVE__DUP2 = True

'' Define to 1 if you have the `_et_list' function. 
'' #undef HAVE__ET_LIST 

'' Define to 1 if you have the `_facl' function. 
'' #undef HAVE__FACL 

'' Define to 1 if you have the `_fchdir' function. 
'' #undef HAVE__FCHDIR 

'' Define to 1 if you have the `_fcntl' function. 
'' #undef HAVE__FCNTL 

'' Define to 1 if you have the `_fork' function. 
'' #undef HAVE__FORK 

'' Define to 1 if you have the `_fstat' function. 
'#Const HAVE__FSTAT = True

'' Define to 1 if you have the `_fstat64' function. 
'#Const HAVE__FSTAT64 = True

'' Define to 1 if you have the `_getcwd' function. 
'#Const HAVE__GETCWD = True

'' Define to 1 if you have the `_llseek' function. 
'' #undef HAVE__LLSEEK 

'' Define to 1 if you have the `_lseek' function. 
'#Const HAVE__LSEEK = True

'' Define to 1 if you have the `_lstat' function. 
'' #undef HAVE__LSTAT 

'' Define to 1 if you have the `_lstat64' function. 
'' #undef HAVE__LSTAT64 

'' Define to 1 if you have the `_open' function. 
'#Const HAVE__OPEN = True

'' Define to 1 if you have the `_open64' function. 
'' #undef HAVE__OPEN64 

'' Define to 1 if you have the `_opendir' function. 
'' #undef HAVE__OPENDIR 

'' Define to 1 if you have the `_pread' function. 
'' #undef HAVE__PREAD 

'' Define to 1 if you have the `_pread64' function. 
'' #undef HAVE__PREAD64 

'' Define to 1 if you have the `_pwrite' function. 
'' #undef HAVE__PWRITE 

'' Define to 1 if you have the `_pwrite64' function. 
'' #undef HAVE__PWRITE64 

'' Define to 1 if you have the `_read' function. 
'#Const HAVE__READ = True

'' Define to 1 if you have the `_readdir' function. 
'' #undef HAVE__READDIR 

'' Define to 1 if you have the `_readdir64' function. 
'' #undef HAVE__READDIR64 

'' Define to 1 if you have the `_seekdir' function. 
'' #undef HAVE__SEEKDIR 

'' Define to 1 if you have the `_stat' function. 
'#Const HAVE__STAT = True

'' Define to 1 if you have the `_stat64' function. 
'#Const HAVE__STAT64 = True

'' Define to 1 if you have the `_telldir' function. 
'' #undef HAVE__TELLDIR 

'' Define to 1 if you have the `_write' function. 
'#Const HAVE__WRITE = True

'' Define to 1 if you have the `__acl' function. 
'' #undef HAVE___ACL 

'' Define to 1 if you have the `__chdir' function. 
'' #undef HAVE___CHDIR 

'' Define to 1 if you have the `__close' function. 
'' #undef HAVE___CLOSE 

'' Define to 1 if you have the `__closedir' function. 
'' #undef HAVE___CLOSEDIR 

'' Define to 1 if you have the `__dup' function. 
'' #undef HAVE___DUP 

'' Define to 1 if you have the `__dup2' function. 
'' #undef HAVE___DUP2 

'' Define to 1 if you have the `__facl' function. 
'' #undef HAVE___FACL 

'' Define to 1 if you have the `__fchdir' function. 
'' #undef HAVE___FCHDIR 

'' Define to 1 if you have the `__fcntl' function. 
'' #undef HAVE___FCNTL 

'' Define to 1 if you have the `__fork' function. 
'' #undef HAVE___FORK 

'' Define to 1 if you have the `__fstat' function. 
'' #undef HAVE___FSTAT 

'' Define to 1 if you have the `__fstat64' function. 
'' #undef HAVE___FSTAT64 

'' Define to 1 if you have the `__fxstat' function. 
'' #undef HAVE___FXSTAT 

'' Define to 1 if you have the `__getcwd' function. 
'' #undef HAVE___GETCWD 

'' Define to 1 if you have the `__getdents' function. 
'' #undef HAVE___GETDENTS 

'' Define to 1 if you have the `__llseek' function. 
'' #undef HAVE___LLSEEK 

'' Define to 1 if you have the `__lseek' function. 
'' #undef HAVE___LSEEK 

'' Define to 1 if you have the `__lstat' function. 
'' #undef HAVE___LSTAT 

'' Define to 1 if you have the `__lstat64' function. 
'' #undef HAVE___LSTAT64 

'' Define to 1 if you have the `__lxstat' function. 
'' #undef HAVE___LXSTAT 

'' Define to 1 if you have the `__open' function. 
'' #undef HAVE___OPEN 

'' Define to 1 if you have the `__open64' function. 
'' #undef HAVE___OPEN64 

'' Define to 1 if you have the `__opendir' function. 
'' #undef HAVE___OPENDIR 

'' Define to 1 if you have the `__pread' function. 
'' #undef HAVE___PREAD 

'' Define to 1 if you have the `__pread64' function. 
'' #undef HAVE___PREAD64 

'' Define to 1 if you have the `__pwrite' function. 
'' #undef HAVE___PWRITE 

'' Define to 1 if you have the `__pwrite64' function. 
'' #undef HAVE___PWRITE64 

'' Define to 1 if you have the `__read' function. 
'' #undef HAVE___READ 

'' Define to 1 if you have the `__readdir' function. 
'' #undef HAVE___READDIR 

'' Define to 1 if you have the `__readdir64' function. 
'' #undef HAVE___READDIR64 

'' Define to 1 if you have the `__seekdir' function. 
'' #undef HAVE___SEEKDIR 

'' Define to 1 if you have the `__stat' function. 
'' #undef HAVE___STAT 

'' Define to 1 if you have the `__stat64' function. 
'' #undef HAVE___STAT64 

'' Define to 1 if you have the `__sys_llseek' function. 
'' #undef HAVE___SYS_LLSEEK 

'' Define to 1 if you have the `__telldir' function. 
'' #undef HAVE___TELLDIR 

'' Whether __va_copy() is available 
'' #undef HAVE___VA_COPY 

'' Define to 1 if you have the `__write' function. 
'' #undef HAVE___WRITE 

'' Define to 1 if you have the `__xstat' function. 
'' #undef HAVE___XSTAT 

'' Whether the host os is HPUX 
'' #undef HPUX 

'' Whether the hpux sendfile() API is available 
'' #undef HPUX_SENDFILE_API 

'' Whether to use intel spinlocks 
'#Const INTEL_SPINLOCKS = True

'' Whether the host os is irix 
'' #undef IRIX 

'' Whether the host os is irix6 
'' #undef IRIX6 

'' Whether krb5_princ_realm returns krb5_realm or krb5_data 
'' #undef KRB5_PRINC_REALM_RETURNS_REALM 

'' Number of arguments to krb5_verify_checksum 
'' #undef KRB5_VERIFY_CHECKSUM_ARGS 

'' Number of arguments to ldap_set_rebind_proc 
'' #undef LDAP_SET_REBIND_PROC_ARGS 

'' Whether the host os is linux 
'' #undef LINUX 

'' Whether (linux) sendfile() is broken 
'' #undef LINUX_BROKEN_SENDFILE_API 

'' Whether linux sendfile() API is available 
'' #undef LINUX_SENDFILE_API 

'' Whether to use mips spinlocks 
'' #undef MIPS_SPINLOCKS 

'' Whether MMAP is broken 
'' #undef MMAP_BLACKLIST 

'' Whether the host os is NeXT v2 
'' #undef NEXT2 

'' Define to 1 if your C compiler doesn't accept -c and -o together. 
'' #undef NO_MINUS_C_MINUS_O 

'' Whether the host os is osf1 
'' #undef OSF1 

'' Define to the address where bug reports for this package should be sent. 
'' #undef PACKAGE_BUGREPORT 

'' Define to the full name of this package. 
'' #undef PACKAGE_NAME 

'' Define to the full name and version of this package. 
'' #undef PACKAGE_STRING 

'' Define to the one symbol short name of this package. 
'' #undef PACKAGE_TARNAME 

'' Define to the version of this package. 
'' #undef PACKAGE_VERSION 

'' Does a POSIX ACL need a mask element 
'' #undef POSIX_ACL_NEEDS_MASK 

'' Whether to use powerpc spinlocks 
'' #undef POWERPC_SPINLOCKS 

'' Whether pututline returns pointer 
'' #undef PUTUTLINE_RETURNS_UTMP 

'' Whether the host os is qnx 
'' #undef QNX 

'' Whether the realpath function allows NULL 
'' #undef REALPATH_TAKES_NULL 

'' Whether the host os is reliantunix 
'' #undef RELIANTUNIX 

'' Whether getpass should be replaced 
'#Const REPLACE_GETPASS = True

'' Whether inet_ntoa should be replaced 
'#Const REPLACE_INET_NTOA = True

'' replace readdir 
'' #undef REPLACE_READDIR 

'' Define as the return type of signal handlers (`int' or `void'). 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define RETSIGTYPE void
'#Const RETSIGTYPE = True

'' Whether the host os is sco unix 
'' #undef SCO 

'' Whether seekdir returns void 
'' #undef SEEKDIR_RETURNS_VOID 

'' The size of the 'dev_t' type 
'' #undef SIZEOF_DEV_T 

'' The size of the 'ino_t' type 
'' #undef SIZEOF_INO_T 

'' The size of a `int', as computed by sizeof. 
'' #undef SIZEOF_INT 

'' The size of a `long', as computed by sizeof. 
'#Const SIZEOF_LONG = True

'' The size of a `long long', as computed by sizeof. 
'#Const SIZEOF_LONG_LONG = True

'' The size of the 'off_t' type 
'' #undef SIZEOF_OFF_T 

'' The size of a `short', as computed by sizeof. 
'#Const SIZEOF_SHORT = True

'' Use socket wrapper library 
'' #undef SOCKET_WRAPPER 

'' Whether the solaris sendfile() API is available 
'' #undef SOLARIS_SENDFILE_API 

'' Whether to use sparc spinlocks 
'' #undef SPARC_SPINLOCKS 

'' Whether statfs requires two arguments and struct statfs has bsize property
''   
'' #undef STAT_STATFS2_BSIZE 

'' Whether statfs requires 2 arguments and struct statfs has fsize 
'' #undef STAT_STATFS2_FSIZE 

'' Whether statfs requires 2 arguments and struct fs_data is available 
'' #undef STAT_STATFS2_FS_DATA 

'' Whether statfs requires 3 arguments 
'' #undef STAT_STATFS3_OSF1 

'' Whether statfs requires 4 arguments 
'' #undef STAT_STATFS4 

'' Whether statvfs() is available 
'' #undef STAT_STATVFS 

'' Whether statvfs64() is available 
'' #undef STAT_STATVFS64 

'' The size of a block 
'' #undef STAT_ST_BLOCKSIZE 

'' Define to 1 if you have the ANSI C header files. 
'' #undef STDC_HEADERS 

'' String list of builtin modules 
'#Const STRING_STATIC_MODULES = True

'' Whether the host os is sunos4 
'' #undef SUNOS4 

'' Whether the host os is solaris 
'' #undef SUNOS5 

'' Whether sysconf(_SC_NGROUPS_MAX) is available 
'' #undef SYSCONF_SC_NGROUPS_MAX 

'' Whether sysconf(_SC_NPROCESSORS_ONLN) is available 
'' #undef SYSCONF_SC_NPROCESSORS_ONLN 

'' Whether sysconf(_SC_NPROC_ONLN) is available 
'' #undef SYSCONF_SC_NPROC_ONLN 

'' Whether sysconf(_SC_PAGESIZE) is available 
'' #undef SYSCONF_SC_PAGESIZE 

'' Whether this is a system V system 
'' #undef SYSV 

'' Define to 1 if you can safely include both <sys/time.h> and <time.h>. 
'' #undef TIME_WITH_SYS_TIME 

'' Whether the host os is unixware 
'' #undef UNIXWARE 

'' Whether to use both of HPUX' crypt calls 
'' #undef USE_BOTH_CRYPT_CALLS 

'' Whether we should build DMAPI integration components 
'' #undef USE_DMAPI 

'' Whether seteuid() is available 
'' #undef USE_SETEUID 

'' Whether setresuid() is available 
'' #undef USE_SETRESUID 

'' Whether setreuid() is available 
'' #undef USE_SETREUID 

'' Whether setuidx() is available 
'' #undef USE_SETUIDX 

'' Whether to use spin locks instead of fcntl locks 
'' #undef USE_SPINLOCKS 

'' Whether to include Active Directory support 
'' #undef WITH_ADS 

'' Whether to include AFS clear-text auth support 
'' #undef WITH_AFS 

'' Using asynchronous io 
'' #undef WITH_AIO 

'' Whether to include automount support 
'' #undef WITH_AUTOMOUNT 

'' Whether to build mount.cifs and umount.cifs 
'' #undef WITH_CIFSMOUNT 

'' Whether to include DFS support 
'' #undef WITH_DFS 

'' Whether to include AFS fake-kaserver support 
'' #undef WITH_FAKE_KASERVER 

'' Whether to include nisplus_home support 
'' #undef WITH_NISPLUS_HOME 

'' Whether to include PAM support 
'' #undef WITH_PAM 

'' Whether to use profiling 
'' #undef WITH_PROFILE 

'' Whether to use disk quota support 
'' #undef WITH_QUOTAS 

'' Whether to include sendfile() support 
'' #undef WITH_SENDFILE 

'' Whether to build smbmount 
'' #undef WITH_SMBMOUNT 

'' Whether to include smbwrapper support 
'' #undef WITH_SMBWRAPPER 

'' Whether to include experimental syslog support 
'' #undef WITH_SYSLOG 

'' Whether to include experimental utmp accounting 
'' #undef WITH_UTMP 

'' Whether to build winbind 
'' #undef WITH_WINBIND 

'' Define to 1 if your processor stores words with the most significant byte
''   first (like Motorola and SPARC, unlike Intel and VAX). 
'' #undef WORDS_BIGENDIAN 

'' Required alignment 
'' #undef _ALIGNMENT_REQUIRED 

'' File offset bits 
'' #undef _FILE_OFFSET_BITS 

'' Whether to use GNU libc extensions 
'' #undef _GNU_SOURCE 

'' Whether to use HPUX extensions 
'' #undef _HPUX_SOURCE 

'' Whether to enable large file support 
'#Const _LARGEFILE64_SOURCE = True

'' Whether to enable large file support 
'#Const _LARGE_FILES = True

'' Maximum alignment 
'' #undef _MAX_ALIGNMENT 

'' Whether to enable POSIX support 
'' #undef _POSIX_C_SOURCE 

'' Whether to use POSIX compatible functions 
'' #undef _POSIX_SOURCE 

'' Whether to enable System V compatibility 
'' #undef _SYSV 

'' Define to 1 if type `char' is unsigned and you are not using gcc.  
'#If Not __CHAR_UNSIGNED__ Then
'' # undef __CHAR_UNSIGNED__ 
'#End If

'' Whether to build auth_builtin as shared module 
'' #undef auth_builtin_init 

'' Whether to build auth_domain as shared module 
'' #undef auth_domain_init 

'' Whether to build auth_sam as shared module 
'' #undef auth_sam_init 

'' Whether to build auth_script as shared module 
'' #undef auth_script_init 

'' Whether to build auth_server as shared module 
'' #undef auth_server_init 

'' Whether to build auth_unix as shared module 
'' #undef auth_unix_init 

'' Whether to build auth_winbind as shared module 
'' #undef auth_winbind_init 

'' Whether to build charset_CP437 as shared module 
'' #undef charset_CP437_init 

'' Whether to build charset_CP850 as shared module 
'' #undef charset_CP850_init 

'' Whether to build charset_macosxfs as shared module 
'' #undef charset_macosxfs_init 

'' Whether to build charset_weird as shared module 
'' #undef charset_weird_init 

'' Define to empty if `const' does not conform to ANSI C. 
'' #undef const 

'' Define to `int' if <sys/types.h> doesn't define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define gid_t int
'#Const gid_t = True

'' Whether to build idmap_ad as shared module 
'' #undef idmap_ad_init 

'' Whether to build idmap_ldap as shared module 
'' #undef idmap_ldap_init 

'' Whether to build idmap_rid as shared module 
'' #undef idmap_rid_init 

'' Whether to build idmap_tdb as shared module 
'' #undef idmap_tdb_init 

'' Define to `__inline__' or `__inline' if that's what the C compiler
''   calls it, or to nothing if 'inline' is not supported under any name.  
'#If Not __cplusplus Then
'' #undef inline 
'#End If

'' Define to `unsigned' if <sys/types.h> does not define. 
'' #undef ino_t 

'' Define to `unsigned long' if <sys/types.h> does not define. 
'' #undef intptr_t 

'' Define to `off_t' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define loff_t UINT64
'#Const loff_t = True

'' Define to `int' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define mode_t int
'#Const mode_t = True

'' Define to `long' if <sys/types.h> does not define. 
'' #undef off_t 

'' Define to `loff_t' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define offset_t UINT64
'#Const offset_t = True

'' Whether to build pdb_ldap as shared module 
'' #undef pdb_ldap_init 

'' Whether to build pdb_smbpasswd as shared module 
'' #undef pdb_smbpasswd_init 

'' Whether to build pdb_tdbsam as shared module 
'' #undef pdb_tdbsam_init 

'' Define to `int' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define pid_t int
'#Const pid_t = True

'' Whether to build rpc_echo as shared module 
'' #undef rpc_echo_init 

'' Whether to build rpc_eventlog as shared module 
'' #undef rpc_eventlog_init 

'' Whether to build rpc_lsa_ds as shared module 
'' #undef rpc_lsa_ds_init 

'' Whether to build rpc_lsa as shared module 
'' #undef rpc_lsa_init 

'' Whether to build rpc_net as shared module 
'' #undef rpc_net_init 

'' Whether to build rpc_netdfs as shared module 
'' #undef rpc_netdfs_init 

'' Whether to build rpc_ntsvcs as shared module 
'' #undef rpc_ntsvcs_init 

'' Whether to build rpc_reg as shared module 
'' #undef rpc_reg_init 

'' Whether to build rpc_samr as shared module 
'' #undef rpc_samr_init 

'' Whether to build rpc_spoolss as shared module 
'' #undef rpc_spoolss_init 

'' Whether to build rpc_srv as shared module 
'' #undef rpc_srv_init 

'' Whether to build rpc_svcctl as shared module 
'' #undef rpc_svcctl_init 

'' Whether to build rpc_wks as shared module 
'' #undef rpc_wks_init 

'' Define to `unsigned' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define size_t unsigned
'#Const size_t = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define _SIZE_T_DEFINED
'#Const _SIZE_T_DEFINED = True

'' Define to `int' if <sys/types.h> does not define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define ssize_t int
'#Const ssize_t = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_auth extern NTSTATUS auth_sam_init(void); extern NTSTATUS auth_unix_init(void); extern NTSTATUS auth_winbind_init(void); extern NTSTATUS auth_server_init(void); extern NTSTATUS auth_domain_init(void); extern NTSTATUS auth_builtin_init(void); extern NTSTATUS auth_script_init(void);
'#Const static_decl_auth = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_charset extern NTSTATUS charset_CP850_init(void); extern NTSTATUS charset_CP437_init(void);
'#Const static_decl_charset = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_idmap extern NTSTATUS idmap_tdb_init(void);
'#Const static_decl_idmap = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_pdb extern NTSTATUS pdb_smbpasswd_init(void); extern NTSTATUS pdb_tdbsam_init(void);
'#Const static_decl_pdb = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_rpc extern NTSTATUS rpc_lsa_init(void); extern NTSTATUS rpc_reg_init(void); extern NTSTATUS rpc_lsa_ds_init(void); extern NTSTATUS rpc_wks_init(void); extern NTSTATUS rpc_svcctl_init(void); extern NTSTATUS rpc_ntsvcs_init(void); extern NTSTATUS rpc_net_init(void); extern NTSTATUS rpc_netdfs_init(void); extern NTSTATUS rpc_srv_init(void); extern NTSTATUS rpc_spoolss_init(void); extern NTSTATUS rpc_eventlog_init(void); extern NTSTATUS rpc_samr_init(void);
'#Const static_decl_rpc = True

'' Decl of Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_decl_vfs extern NTSTATUS vfs_recycle_init(void); extern NTSTATUS vfs_audit_init(void); extern NTSTATUS vfs_extd_audit_init(void); extern NTSTATUS vfs_full_audit_init(void); extern NTSTATUS vfs_netatalk_init(void); extern NTSTATUS vfs_fake_perms_init(void); extern NTSTATUS vfs_default_quota_init(void); extern NTSTATUS vfs_readonly_init(void); extern NTSTATUS vfs_cap_init(void); extern NTSTATUS vfs_expand_msdfs_init(void); extern NTSTATUS vfs_shadow_copy_init(void);
'#Const static_decl_vfs = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_auth { auth_sam_init(); auth_unix_init(); auth_winbind_init(); auth_server_init(); auth_domain_init(); auth_builtin_init(); auth_script_init();}
'#Const static_init_auth = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_charset { charset_CP850_init(); charset_CP437_init();}
'#Const static_init_charset = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_idmap { idmap_tdb_init();}
'#Const static_init_idmap = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_pdb { pdb_smbpasswd_init(); pdb_tdbsam_init();}
'#Const static_init_pdb = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_rpc { rpc_lsa_init(); rpc_reg_init(); rpc_lsa_ds_init(); rpc_wks_init(); rpc_svcctl_init(); rpc_ntsvcs_init(); rpc_net_init(); rpc_netdfs_init(); rpc_srv_init(); rpc_spoolss_init(); rpc_eventlog_init(); rpc_samr_init();}
'#Const static_init_rpc = True

'' Static init functions 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define static_init_vfs { vfs_recycle_init(); vfs_audit_init(); vfs_extd_audit_init(); vfs_full_audit_init(); vfs_netatalk_init(); vfs_fake_perms_init(); vfs_default_quota_init(); vfs_readonly_init(); vfs_cap_init(); vfs_expand_msdfs_init(); vfs_shadow_copy_init();}
'#Const static_init_vfs = True

'' Define to `int' if <sys/types.h> doesn't define. 
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define uid_t int
'#Const uid_t = True

'' Whether to build vfs_afsacl as shared module 
'' #undef vfs_afsacl_init 

'' Whether to build vfs_audit as shared module 
'' #undef vfs_audit_init 

'' Whether to build vfs_cap as shared module 
'' #undef vfs_cap_init 

'' Whether to build vfs_catia as shared module 
'' #undef vfs_catia_init 

'' Whether to build vfs_default_quota as shared module 
'' #undef vfs_default_quota_init 

'' Whether to build vfs_expand_msdfs as shared module 
'' #undef vfs_expand_msdfs_init 

'' Whether to build vfs_extd_audit as shared module 
'' #undef vfs_extd_audit_init 

'' Whether to build vfs_fake_perms as shared module 
'' #undef vfs_fake_perms_init 

'' Whether to build vfs_full_audit as shared module 
'' #undef vfs_full_audit_init 

'' Whether to build vfs_netatalk as shared module 
'' #undef vfs_netatalk_init 

'' Whether to build vfs_readonly as shared module 
'' #undef vfs_readonly_init 

'' Whether to build vfs_recycle as shared module 
'' #undef vfs_recycle_init 

'' Whether to build vfs_shadow_copy as shared module 
'' #undef vfs_shadow_copy_init 

'' Define to `unsigned short' if <sys/types.h> does not define. 
'' #undef wchar_t 

'#End If
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_KARAOKE
'#Const HAS_KARAOKE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_PYTHON
'#Const HAS_PYTHON = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_WEB_SERVER
'#Const HAS_WEB_SERVER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_EVENT_SERVER
'#Const HAS_EVENT_SERVER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_UPNP
'#Const HAS_UPNP = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_AUDIO
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SHOUTCAST
'#Const HAS_SHOUTCAST = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SDL
'#Const HAS_SDL = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_RAR
'#Const HAS_RAR = True
'#If Not __APPLE__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_HAL
'#Const HAS_HAL = True
'#End If
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_CDDA
'#Const HAS_FILESYSTEM_CDDA = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_SMB
'#Const HAS_FILESYSTEM_SMB = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM
'#Const HAS_FILESYSTEM = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SYSINFO
'#Const HAS_SYSINFO = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_VIDEO_PLAYBACK
'#Const HAS_VIDEO_PLAYBACK = True
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_MPLAYER
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_VISUALISATION
'#Const HAS_VISUALISATION = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVDPLAYER
'#Const HAS_DVDPLAYER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVD_DRIVE
'#Const HAS_DVD_DRIVE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_WMA_CODEC
'#Const HAS_WMA_CODEC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_CCXSTREAM
'#Const HAS_CCXSTREAM = True
'#If Not __APPLE__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_LIRC
'#Const HAS_LIRC = True
'#End If
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_AC3_CODEC
'#Const HAS_AC3_CODEC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DTS_CODEC
'#Const HAS_DTS_CODEC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_CDDA_RIPPER
'#Const HAS_CDDA_RIPPER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_RTV
'#Const HAS_FILESYSTEM_RTV = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_DAAP
'#Const HAS_FILESYSTEM_DAAP = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_VTP
'#Const HAS_FILESYSTEM_VTP = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_PERFORMANCE_SAMPLE
'#Const HAS_PERFORMANCE_SAMPLE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_LINUX_NETWORK
'#Const HAS_LINUX_NETWORK = True

''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <unistd.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <netdb.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <arpa/inet.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <netinet/in.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <sys/socket.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include <sys/types.h>
''C++ TO VB CONVERTER WARNING: The following #include directive was ignored:
''#include "PlatformInclude.h"
'#End If

'#If HAS_SDL Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SDL_AUDIO
'#Const HAS_SDL_AUDIO = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVD_SWSCALE
'#Const HAS_DVD_SWSCALE = True
'#If Not HAS_SDL_2D Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SDL_OPENGL
'#Const HAS_SDL_OPENGL = True
'#If _LINUX Then
'#If Not __APPLE__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_GLX
'#Const HAS_GLX = True
'#End If
'#End If
'#End If
'#If _WIN32 Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define _WIN32PC
'#Const _WIN32PC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_AC3_CODEC
'#Const HAS_AC3_CODEC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DTS_CODEC
'#Const HAS_DTS_CODEC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_CDDA_RIPPER
'#Const HAS_CDDA_RIPPER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVD_SWSCALE
'#Const HAS_DVD_SWSCALE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM
'#Const HAS_FILESYSTEM = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_SMB
'#Const HAS_FILESYSTEM_SMB = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_CDDA
'#Const HAS_FILESYSTEM_CDDA = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_RTV
'#Const HAS_FILESYSTEM_RTV = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_DAAP
'#Const HAS_FILESYSTEM_DAAP = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_SAP
'#Const HAS_FILESYSTEM_SAP = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_FILESYSTEM_VTP
'#Const HAS_FILESYSTEM_VTP = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_DVD_DRIVE
'#Const HAS_DVD_DRIVE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_VISUALISATION
'#Const HAS_VISUALISATION = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_CCXSTREAM
'#Const HAS_CCXSTREAM = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_EVENT_SERVER
'#Const HAS_EVENT_SERVER = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SHOUTCAST
'#Const HAS_SHOUTCAST = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_WIN32_NETWORK
'#Const HAS_WIN32_NETWORK = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_LIRC
'#Const HAS_LIRC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_IRSERVERSUITE
'#Const HAS_IRSERVERSUITE = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SYSINFO
'#Const HAS_SYSINFO = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_SDL_JOYSTICK
'#Const HAS_SDL_JOYSTICK = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define HAS_KARAOKE
'#Const HAS_KARAOKE = True

''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_SDL_AUDIO ' use dsound for audio on win32
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_PERFORMANCE_SAMPLE ' no performance sampling
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef HAS_LINUX_NETWORK

'#If Not __PLATFORM_INCLUDE__H__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define __PLATFORM_INCLUDE__H__
'#Const __PLATFORM_INCLUDE__H__ = True

''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'#If Not __PLATFORM_DEFS_H__ Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define __PLATFORM_DEFS_H__
'#Const __PLATFORM_DEFS_H__ = True

''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'#If _WIN32 Then

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define __STDC_FORMAT_MACROS
'#Const __STDC_FORMAT_MACROS = True


''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define snprintf _snprintf
'#Const snprintf = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define ftello64 _ftelli64
'#Const ftello64 = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define fseeko64 _fseeki64
'#Const fseeko64 = True

'#If Not PRIdS Then
'#Const PRIdS = True
'#End If

'#End If ' _WIN32

'#End If '__PLATFORM_DEFS_H__



'#End If


'#End If
'#End If

'#If Not SVN_REV Then
'#Const SVN_REV = True
'#End If
''Tangible Process Only End
'#End If


''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'Namespace HTML
'Public Class CHTMLUtil
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub New()
'  Public Overridable Sub Dispose()
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer FindTag(const CStdString& strHTML, const CStdString& strTag, CStdString& strtagFound, Integer iPos = 0) const;
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Function FindTag(ByVal strHTML As CStdString, ByVal strTag As CStdString, ByRef strtagFound As CStdString, Optional ByVal iPos As Integer = 0) As Integer
''C++ TO VB CONVERTER WARNING: 'const' methods are not available in VB:
''ORIGINAL LINE: Integer FindClosingTag(const CStdString& strHTML, const CStdString& strTag, CStdString& strtagFound, Integer iPos) const;
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Function FindClosingTag(ByVal strHTML As CStdString, ByVal strTag As CStdString, ByRef strtagFound As CStdString, ByVal iPos As Integer) As Integer
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub getValueOfTag(ByVal strTagAndValue As CStdString, ByRef strValue As CStdString)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub getAttributeOfTag(ByVal strTagAndValue As CStdString, ByVal strTag As CStdString, ByRef strValue As CStdString)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RemoveTags(ByRef strHTML As CStdString)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub ConvertHTMLToAnsi(ByVal strHTML As CStdString, ByRef strStripped As String)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub ConvertHTMLToUTF8(ByVal strHTML As CStdString, ByRef strStripped As String)
'End Class
'End Namespace
''Tangible Process Only End
''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''class CFileItemList;

'Namespace DIRECTORY
''!
'' \ingroup filesystem 
'' \brief Wrappers for \e IDirectory
'' 
'Public Class CDirectory
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub New()
'  Public Overridable Sub Dispose()

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetDirectory(ByVal strPath As std::map, ByRef items As CFileItemList, Optional ByVal strMask As std::map = "", Optional ByVal bUseFileDirectories As Boolean = True, Optional ByVal allowPrompting As Boolean = False, Optional ByVal cacheDirectory As Boolean = False) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function Create(ByVal strPath As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function Exists(ByVal strPath As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function Remove(ByVal strPath As std::map) As Boolean
'End Class
'End Namespace
''Tangible Process Only End
''
'' *      Copyright (C) 2005-2008 Team XBMC
'' *      http://www.xbmc.org
'' *
'' *  This Program is free software; you can redistribute it and/or modify
'' *  it under the terms of the GNU General Public License as published by
'' *  the Free Software Foundation; either version 2, or (at your option)
'' *  any later version.
'' *
'' *  This Program is distributed in the hope that it will be useful,
'' *  but WITHOUT ANY WARRANTY; without even the implied warranty of
'' *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
'' *  GNU General Public License for more details.
'' *
'' *  You should have received a copy of the GNU General Public License
'' *  along with XBMC; see the file COPYING.  If not, write to
'' *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
'' *  http://www.gnu.org/copyleft/gpl.html
'' *
'' 

'#If min Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef min
'#End If
'#If max Then
''C++ TO VB CONVERTER TODO TASK: There is no equivalent to #undef in VB.NET:
''#undef max
'#End If


'Namespace XFILE
''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''  class IFileCallback;
'End Namespace

''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''class CFileItem;
''C++ TO VB CONVERTER NOTE: VB has no need of forward class declarations:
''class CFileItemList;

'Public Class sortstringbyname
''C++ TO VB CONVERTER TODO TASK: The () operator cannot be overloaded in VB:
'  Public Shared Operator ()(ByVal strItem1 As std.map, ByVal strItem2 As std.map) As Boolean
'	GlobalMembersScraperParser.std.map< strLine1 = strItem1
'	GlobalMembersScraperParser.std.map< strLine2 = strItem2
'	strLine1 = strLine1.ToLower()
'	strLine2 = strLine2.ToLower()
'	Return String.Compare(strLine1.c_str(), strLine2.c_str()) < 0
'  End Operator
'End Class

''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define PTH_IC(x) CUtil::TranslatePathConvertCase(x)
'#Const PTH_IC = True
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define _P(x) CUtil::TranslatePath(x)
'#Const _P = True
'#If _WIN32PC Then
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define PATH_SEPARATOR_CHAR "\"c
'#Const PATH_SEPARATOR_CHAR = True
'#Const PATH_SEPARATOR_STRING_AlternateDefinition1 = True
'#Const PATH_SEPARATOR_STRING = True
'#Else
''C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
''ORIGINAL LINE: #define PATH_SEPARATOR_CHAR "/"c
'#Const PATH_SEPARATOR_CHAR = True
'#Const PATH_SEPARATOR_STRING_AlternateDefinition2 = True
'#Const PATH_SEPARATOR_STRING = True
'#End If

'Public Class XBOXDETECTION
'   Public As List <GlobalMembersScraperParser.std.map(Of ) client_ip
'   Public As List <GlobalMembersScraperParser.std.map(Of ) client_info
'  Public client_lookup_count As List(Of UInteger)
'  Public client_informed As List(Of Boolean)
'End Class

'Namespace MathUtils
'End Namespace ' namespace MathUtils

'Public Class CUtil
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Sub New()
'  Public Overridable Sub Dispose()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetExtension(ByVal strFileName As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RemoveExtension(ByRef strFileName As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetVolumeFromFileName(ByVal strFileName As std::map, ByRef strFileTitle As std::map, ByRef strVolumeNumber As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub CleanString(ByRef strFileName As std::map, Optional ByVal bIsFolder As Boolean = False)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetFileName(ByVal strFileNameAndPath As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetTitleFromPath(ByVal strFileNameAndPath As std::map, Optional ByVal bIsFolder As Boolean = False)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetCommonPath(ByRef strPath As std::map, ByVal strPath2 As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsHD(ByVal strFileName As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsBuiltIn(ByVal execString As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetBuiltInHelp(ByRef help As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function ExecBuiltIn(ByVal execString As std::map) As Integer
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetParentPath(ByVal strPath As std::map, ByRef strParent As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetMovieName(ByVal pItem As CFileItem, Optional ByVal bUseFolderNames As Boolean = False)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetQualifiedFilename(ByVal strBasePath As std::map, ByRef strFilename As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RunShortcut(ByVal szPath As String)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetDirectory(ByVal strFilePath As std::map, ByRef strDirectoryPath As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetHomePath(ByRef strPath As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ReplaceExtension(ByVal strFile As std::map, ByVal strNewExtension As std::map, ByRef strChangedFile As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetExtension(ByVal strFile As std::map, ByRef strExtension As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function HasSlashAtEnd(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsRemote(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsOnDVD(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsOnLAN(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsDVD(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsVirtualPath(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsMultiPath(ByVal strPath As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsStack(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsRAR(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsInRAR(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsZIP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsInZIP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsInArchive(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsCDDA(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsMemCard(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsTuxBox(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsMythTV(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsVTP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsTV(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function ExcludeFileOrFolder(ByVal strFileOrFolder As std::map, ByVal regexps As List(Of CStdString)) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetFileAndProtocol(ByVal strURL As std::map, ByRef strDir As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetDVDIfoTitle(ByVal strPathFile As std::map) As Integer
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub UrlDecode(ByRef strURLData As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub URLEncode(ByRef strURLData As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetDirectoryName(ByVal strFileName As std::map, ByRef strDescription As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub CreateShortcuts(ByRef items As CFileItemList)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub CreateShortcut(ByVal pItem As CFileItem)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetArtistDatabase(ByVal strFileName As std::map, ByRef strArtistDBS As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetGenreDatabase(ByVal strFileName As std::map, ByRef strGenreDBS As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsISO9660(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsSmb(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsDAAP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsUPnP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ConvertPathToUrl(ByVal strPath As std::map, ByVal strProtocol As std::map, ByRef strOutUrl As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetDVDDriveIcon(ByVal strPath As std::map, ByRef strIcon As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RemoveTempFiles()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub DeleteGUISettings()

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub CacheSubtitles(ByVal strMovie As std::map, ByRef strExtensionCached As std::map, Optional ByVal pCallback As XFILE::IFileCallback = DefineConstantsScraperParser.NULL)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function CacheRarSubtitles(ByRef vecExtensionsCached As List(Of ), ByVal strRarPath As std::map, ByVal strCompare As std::map, Optional ByVal strExtExt As std::map = "") As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ClearSubtitles()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub PrepareSubtitleFonts()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function ToInt64(ByVal dwHigh As UInteger, ByVal dwLow As UInteger) As Long
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub AddFileToFolder(ByVal strFolder As std::map, ByVal strFile As std::map, ByRef strResult As std::map)
'  Public Shared std.map< AddFileToFolder(ByVal strFolder As std.map, ByVal strFile As std.map)
'	GlobalMembersScraperParser.std.map< result
'	AddFileToFolder(strFolder, strFile, result)
'	Return result
'  End Function
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub AddSlashAtEnd(ByRef strFolder As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RemoveSlashAtEnd(ByRef strFolder As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub Split(ByVal strFileNameAndPath As std::map, ByRef strPath As std::map, ByRef strFileName As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub CreateArchivePath(ByRef strUrlPath As std::map, ByVal strType As std::map, ByVal strArchivePath As std::map, ByVal strFilePathInArchive As std::map, Optional ByVal strPwd As std::map = "")
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function ThumbExists(ByVal strFileName As std::map, Optional ByVal bAddCache As Boolean = False) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function ThumbCached(ByVal strFileName As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ThumbCacheAdd(ByVal strFileName As std::map, ByVal bFileExists As Boolean)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ThumbCacheClear()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub PlayDVD()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetNextFilename(ByVal fn_template As String, ByVal max As Integer)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub TakeScreenshot()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub TakeScreenshot(ByVal fn As String, ByVal flash As Boolean)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub SetBrightnessContrastGamma(ByVal Brightness As Single, ByVal Contrast As Single, ByVal Gamma As Single, ByVal bImmediate As Boolean)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub SetBrightnessContrastGammaPercent(ByVal iBrightNess As Integer, ByVal iContrast As Integer, ByVal iGamma As Integer, ByVal bImmediate As Boolean)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub Tokenize(ByVal path As std::map, ByRef tokens As List(Of ), ByVal delimiters As String)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub FlashScreen(ByVal bImmediate As Boolean, ByVal bOn As Boolean)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub RestoreBrightnessContrastGamma()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub InitGamma()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ClearCache()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub StatToStatI64(ByRef result As _stati64, ByRef stat As stat)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub Stat64ToStatI64(ByRef result As _stati64, ByRef stat As __stat64)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub StatI64ToStat64(ByRef result As __stat64, ByRef stat As _stati64)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub Stat64ToStat(ByRef result As stat, ByRef stat As __stat64)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function CreateDirectoryEx(ByVal strPath As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< MakeLegalFileName(ByVal strFile As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub AddDirectorySeperator(ByRef strPath As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetDirectorySeperator(ByVal strFile As std::map) As SByte

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsUsingTTFSubtitles() As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub SplitExecFunction(ByVal execString As std::map, ByRef strFunction As std::map, ByRef strParam As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetMatchingSource(ByVal strPath As std::map, ByRef  As List(Of CMediaSource), ByRef bIsSourceName As Boolean) As Integer
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< TranslateSpecialPath(ByVal strSpecial As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< TranslateSpecialSource(ByVal strSpecial As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub DeleteDirectoryCache(Optional ByVal strType As std::map = "")
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub DeleteMusicDatabaseDirectoryCache()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub DeleteVideoDatabaseDirectoryCache()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< MusicPlaylistsLocation()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< VideoPlaylistsLocation()
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< SubstitutePath(ByVal strFileName As std::map)

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function SetSysDateTimeYear(ByVal iYear As Integer, ByVal iMonth As Integer, ByVal iDay As Integer, ByVal iHour As Integer, ByVal iMinute As Integer) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GMTZoneCalc(ByVal iRescBiases As Integer, ByVal iHour As Integer, ByVal iMinute As Integer, ByRef iMinuteNew As Integer) As Integer
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function IsFTP(ByVal strFile As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function GetFTPServerUserName(ByVal iFTPUserID As Integer, ByRef strFtpUser1 As std::map, ByRef iUserMax As Integer) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function SetFTPServerUserPassword(ByVal strFtpUserName As std::map, ByVal strFtpUserPassword As std::map) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function AutoDetectionPing(ByVal strFTPUserName As std::map, ByVal strFTPPass As std::map, ByVal strNickName As std::map, ByVal iFTPPort As Integer) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function AutoDetection() As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub AutoDetectionGetSource(ByRef share As List(Of CMediaSource))
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetSkinThemes(ByRef vecTheme As List(Of ))
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetRecursiveListing(ByVal strPath As std::map, ByRef items As CFileItemList, ByVal strMask As std::map, Optional ByVal bUseFileDirectories As Boolean = False)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub GetRecursiveDirsListing(ByVal strPath As std::map, ByRef items As CFileItemList)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub WipeDir(ByVal strPath As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ForceForwardSlashes(ByRef strPath As std::map)

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function AlbumRelevance(ByVal strAlbumTemp1 As std::map, ByVal strAlbum1 As std::map, ByVal strArtistTemp1 As std::map, ByVal strArtist1 As std::map) As Double
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function MakeShortenPath(ByVal StrInput As std::map, ByRef StrOutput As std::map, ByVal iTextMaxLength As Integer) As Boolean
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function SupportsFileOperations(ByVal strPath As std::map) As Boolean

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetCachedMusicThumb(ByVal path As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< GetCachedAlbumThumb(ByVal album As std::map, ByVal artist As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Sub ClearFileItemCache()

''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< TranslatePath(ByVal path As std::map)
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared std::map< TranslatePathConvertCase(ByVal path As std::map)

'#If _LINUX Then
'  ' this will run the command using sudo in a new process.
'  ' the user that runs xbmc should be allowed to issue the given sudo command.
'  ' in order to allow a user to run sudo without supplying the password you'll need to edit sudoers
'  ' # sudo visudo
'  ' and add a line at the end defining the user and allowed commands
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function SudoCommand(ByVal strCommand As std::map) As Boolean

'  '
'  ' Forks to execute a shell command.
'  '
''C++ TO VB CONVERTER TODO TASK: The implementation of the following method could not be found:
''  Shared Function Command(ByVal arrArgs As List(Of CStdString)) As Boolean
'#End If


'  Private Shared m_hCurrentCpuUsage As CXHandle
'End Class

''Tangible Process Only End



''C++ TO VB CONVERTER WARNING: The declaration of the following method implementation was not found:
''ORIGINAL LINE: void CScraperParser::ReplaceBuffers(std::map<& strDest)

''C++ TO VB CONVERTER WARNING: The declaration of the following method implementation was not found:
''ORIGINAL LINE: void CScraperParser::ParseExpression(const std::map<& input, std::map<& dest, TiXmlElement* element, Boolean bAppend)

''C++ TO VB CONVERTER WARNING: The declaration of the following method implementation was not found:
''ORIGINAL LINE: void CScraperParser::Clean(std::map<& strDirty)

''C++ TO VB CONVERTER WARNING: The declaration of the following method implementation was not found:
''ORIGINAL LINE: SByte* CScraperParser::RemoveWhiteSpace(String string2)


'Friend NotInheritable Class DefineConstantsScraperParser
'	Public Const MAX_FMT_TRIES As Integer = 5
'	Public Const FMT_BLOCK_SIZE As Integer = 2048
'	Public Const BUFSIZE_1ST As Integer = 256
'	Public Const BUFSIZE_2ND As Integer = 512
'	Public Const STD_BUF_SIZE As Integer = 1024
'	Public Const SSSO_UNICODE As Integer = &H01
'	Public Const SSSO_COMPRESS As Integer = &H02
'	Public Const MAX_SCRAPER_BUFFERS As Integer = 20
'	Public Const DIRECTINPUT_VERSION As Integer = &H0800
'	Public Const BROKEN_NISPLUS_INCLUDE_FILES As Integer = 1
'	Public Const COMPILER_SUPPORTS_LL As Integer = 1
'	Public Const DEFAULT_DISPLAY_CHARSET As String = "ASCII"
'	Public Const DEFAULT_DOS_CHARSET As String = "ASCII"
'	Public Const DEFAULT_UNIX_CHARSET As String = "UTF8"
'	Public Const HAVE_ATEXIT As Integer = 1
'	Public Const HAVE_CHMOD As Integer = 1
'	Public Const HAVE_CTYPE_H As Integer = 1
'	Public Const HAVE_DIRENT_H As Integer = 1
'	Public Const HAVE_DUP2 As Integer = 1
'	Public Const HAVE_EXECL As Integer = 1
'	Public Const HAVE_FCNTL_H As Integer = 1
'	Public Const HAVE_FCVT As Integer = 1
'	Public Const HAVE_FSTAT As Integer = 1
'	Public Const HAVE_FSTAT64 As Integer = 1
'	Public Const HAVE_FTRUNCATE As Integer = 1
'	Public Const HAVE_FUNCTION_MACRO As Integer = 1
'	Public Const HAVE_GETCWD As Integer = 1
'	Public Const HAVE_ICONV As Integer = 1
'	Public Const HAVE_LIMITS_H As Integer = 1
'	Public Const HAVE_LOCALE_H As Integer = 1
'	Public Const HAVE_LONGLONG As Integer = 1
'	Public Const HAVE_LSEEK64 As Integer = 1
'	Public Const HAVE_MEMMOVE As Integer = 1
'	Public Const HAVE_MEMORY_H As Integer = 1
'	Public Const HAVE_MEMSET As Integer = 1
'	Public Const HAVE_MKTIME As Integer = 1
'	Public Const HAVE_NATIVE_ICONV As Integer = 1
'	Public Const HAVE_NO_ACLS As Integer = 1
'	Public Const HAVE_NO_AIO As Integer = 1
'	Public Const HAVE_OFF64_T As Integer = 1
'	Public Const HAVE_RAND As Integer = 1
'	Public Const HAVE_RENAME As Integer = 1
'	Public Const HAVE_ROOT As Integer = 1
'	Public Const HAVE_SELECT As Integer = 1
'	Public Const HAVE_SETLOCALE As Integer = 1
'	Public Const HAVE_SIG_ATOMIC_T_TYPE As Integer = 1
'	Public Const HAVE_SNPRINTF As Integer = 1
'	Public Const HAVE_SNPRINTF_DECL As Integer = 1
'	Public Const HAVE_SRAND As Integer = 1
'	Public Const HAVE_STAT64 As Integer = 1
'	Public Const HAVE_STAT_ST_ATIM As Integer = 1
'	Public Const HAVE_STAT_ST_CTIM As Integer = 1
'	Public Const HAVE_STAT_ST_MTIM As Integer = 1
'	Public Const HAVE_STDARG_H As Integer = 1
'	Public Const HAVE_STDLIB_H As Integer = 1
'	Public Const HAVE_STRCASECMP As Integer = 1
'	Public Const HAVE_STRCHR As Integer = 1
'	Public Const HAVE_STRDUP As Integer = 1
'	Public Const HAVE_STRERROR As Integer = 1
'	Public Const HAVE_STRFTIME As Integer = 1
'	Public Const HAVE_STRING_H As Integer = 1
'	Public Const HAVE_STRPBRK As Integer = 1
'	Public Const HAVE_STRTOUL As Integer = 1
'	Public Const HAVE_STRUCT_STAT_ST_RDEV As Integer = 1
'	Public Const HAVE_ST_RDEV As Integer = 1
'	Public Const HAVE_SYS_STAT_H As Integer = 1
'	Public Const HAVE_SYS_TYPES_H As Integer = 1
'	Public Const HAVE_UNSIGNED_CHAR As Integer = 1
'	Public Const HAVE_UTIMBUF As Integer = 1
'	Public Const HAVE_UTIME As Integer = 1
'	Public Const HAVE_VSNPRINTF As Integer = 1
'	Public Const HAVE_VSNPRINTF_DECL As Integer = 1
'	Public Const HAVE_WAITPID As Integer = 1
'	Public Const HAVE__CHDIR As Integer = 1
'	Public Const HAVE__CLOSE As Integer = 1
'	Public Const HAVE__DUP As Integer = 1
'	Public Const HAVE__DUP2 As Integer = 1
'	Public Const HAVE__FSTAT As Integer = 1
'	Public Const HAVE__FSTAT64 As Integer = 1
'	Public Const HAVE__GETCWD As Integer = 1
'	Public Const HAVE__LSEEK As Integer = 1
'	Public Const HAVE__OPEN As Integer = 1
'	Public Const HAVE__READ As Integer = 1
'	Public Const HAVE__STAT As Integer = 1
'	Public Const HAVE__STAT64 As Integer = 1
'	Public Const HAVE__WRITE As Integer = 1
'	Public Const INTEL_SPINLOCKS As Integer = 1
'	Public Const REPLACE_GETPASS As Integer = 1
'	Public Const REPLACE_INET_NTOA As Integer = 1
'	Public Const SIZEOF_LONG As Integer = 4
'	Public Const SIZEOF_LONG_LONG As Integer = 8
'	Public Const SIZEOF_SHORT As Integer = 2
'	Public Const STRING_STATIC_MODULES As String = "xbox dummy string"
'	Public Const _LARGEFILE64_SOURCE As Integer = 1
'	Public Const _LARGE_FILES As Integer = 1
'	Public Const PRIdS As String = "Id"
'	Public Const SVN_REV As String = "Unknown"
'	Public Const NSUBEXP As Integer = 10
'	Public Const FALSE As Integer = 0
'	Public Const TRUE As Integer = 1
'	Public Const NULL As Integer = 0
'	Public Const INFINITE As Long = &HFFFFFFFFL
'	Public Const STATUS_ABANDONED_WAIT_0 As Integer = &H00000080
'	Public Const PRE_SKIN_VERSION_2_1_COMPATIBILITY As Integer = 1
'#If DEFAULT_SKIN_AlternateDefinition1 Then
'	Public Const DEFAULT_SKIN As String = "Project Mayhem III"
'#ElseIf DEFAULT_SKIN_AlternateDefinition2 Then
'	Public Const DEFAULT_SKIN As String = "PM3.HD"
'#End If
'#If DEFAULT_THUMB_SIZE_AlternateDefinition1 Then
'	Public Const DEFAULT_THUMB_SIZE As Integer = 256
'#ElseIf DEFAULT_THUMB_SIZE_AlternateDefinition2 Then
'	Public Const DEFAULT_THUMB_SIZE As Integer = 512
'#End If
'	Public Const RENDER_METHOD_AUTO As Integer = 0
'	Public Const RENDER_METHOD_ARB As Integer = 1
'	Public Const RENDER_METHOD_GLSL As Integer = 2
'	Public Const RENDER_METHOD_SOFTWARE As Integer = 3
'	Public Const RENDER_OVERLAYS As Integer = 99
'	Public Const SOFTWARE_UPSCALING_DISABLED As Integer = 0
'	Public Const SOFTWARE_UPSCALING_SD_CONTENT As Integer = 1
'	Public Const SOFTWARE_UPSCALING_ALWAYS As Integer = 2
'	Public Const BLANKING_DISABLED As Integer = 0
'	Public Const BLANKING_ALL_DISPLAYS As Integer = 1
'	Public Const APPLE_REMOTE_DISABLED As Integer = 0
'	Public Const APPLE_REMOTE_STANDARD As Integer = 1
'	Public Const APPLE_REMOTE_UNIVERSAL As Integer = 2
'	Public Const SUBTITLE_COLOR_START As Integer = 0
'	Public Const SUBTITLE_COLOR_END As Integer = 5
'	Public Const CDDARIP_ENCODER_LAME As Integer = 0
'	Public Const CDDARIP_ENCODER_VORBIS As Integer = 1
'	Public Const CDDARIP_ENCODER_WAV As Integer = 2
'	Public Const CDDARIP_QUALITY_CBR As Integer = 0
'	Public Const CDDARIP_QUALITY_MEDIUM As Integer = 1
'	Public Const CDDARIP_QUALITY_STANDARD As Integer = 2
'	Public Const CDDARIP_QUALITY_EXTREME As Integer = 3
'	Public Const AUDIO_ANALOG As Integer = 0
'	Public Const AUDIO_DIGITAL As Integer = 1
'	Public Const VIDEO_NORMAL As Integer = 0
'	Public Const VIDEO_LETTERBOX As Integer = 1
'	Public Const VIDEO_WIDESCREEN As Integer = 2
'	Public Const LCD_TYPE_NONE As Integer = 0
'	Public Const LCD_TYPE_LCD_HD44780 As Integer = 1
'	Public Const LCD_TYPE_LCD_KS0073 As Integer = 2
'	Public Const LCD_TYPE_VFD As Integer = 3
'	Public Const LCD_TYPE_LCDPROC As Integer = 4
'	Public Const MODCHIP_SMARTXX As Integer = 0
'	Public Const MODCHIP_XENIUM As Integer = 1
'	Public Const MODCHIP_XECUTER3 As Integer = 2
'	Public Const LED_COLOUR_NO_CHANGE As Integer = 0
'	Public Const LED_COLOUR_GREEN As Integer = 1
'	Public Const LED_COLOUR_ORANGE As Integer = 2
'	Public Const LED_COLOUR_RED As Integer = 3
'	Public Const LED_COLOUR_CYCLE As Integer = 4
'	Public Const LED_COLOUR_OFF As Integer = 5
'	Public Const FRAME_RATE_LEAVE_AS_IS As Integer = 0
'	Public Const FRAME_RATE_CONVERT As Integer = 1
'	Public Const FRAME_RATE_USE_PAL60 As Integer = 2
'	Public Const LED_PLAYBACK_OFF As Integer = 0
'	Public Const LED_PLAYBACK_VIDEO As Integer = 1
'	Public Const LED_PLAYBACK_MUSIC As Integer = 2
'	Public Const LED_PLAYBACK_VIDEO_MUSIC As Integer = 3
'	Public Const SPIN_DOWN_NONE As Integer = 0
'	Public Const SPIN_DOWN_MUSIC As Integer = 1
'	Public Const SPIN_DOWN_VIDEO As Integer = 2
'	Public Const SPIN_DOWN_BOTH As Integer = 3
'	Public Const AAM_QUIET As Integer = 1
'	Public Const AAM_FAST As Integer = 0
'	Public Const APM_HIPOWER As Integer = 0
'	Public Const APM_LOPOWER As Integer = 1
'	Public Const APM_HIPOWER_STANDBY As Integer = 2
'	Public Const APM_LOPOWER_STANDBY As Integer = 3
'	Public Const SETTINGS_TYPE_BOOL As Integer = 1
'	Public Const SETTINGS_TYPE_FLOAT As Integer = 2
'	Public Const SETTINGS_TYPE_INT As Integer = 3
'	Public Const SETTINGS_TYPE_STRING As Integer = 4
'	Public Const SETTINGS_TYPE_HEX As Integer = 5
'	Public Const SETTINGS_TYPE_SEPARATOR As Integer = 6
'	Public Const CHECKMARK_CONTROL As Integer = 1
'	Public Const SPIN_CONTROL_FLOAT As Integer = 2
'	Public Const SPIN_CONTROL_INT As Integer = 3
'	Public Const SPIN_CONTROL_INT_PLUS As Integer = 4
'	Public Const SPIN_CONTROL_TEXT As Integer = 5
'	Public Const EDIT_CONTROL_INPUT As Integer = 6
'	Public Const EDIT_CONTROL_HIDDEN_INPUT As Integer = 7
'	Public Const EDIT_CONTROL_NUMBER_INPUT As Integer = 8
'	Public Const EDIT_CONTROL_IP_INPUT As Integer = 9
'	Public Const BUTTON_CONTROL_STANDARD As Integer = 10
'	Public Const BUTTON_CONTROL_MISC_INPUT As Integer = 11
'	Public Const BUTTON_CONTROL_PATH_INPUT As Integer = 12
'	Public Const SEPARATOR_CONTROL As Integer = 13
'	Public Const RESUME_NO As Integer = 0
'	Public Const RESUME_YES As Integer = 1
'	Public Const RESUME_ASK As Integer = 2
'	Public Const REPLAY_GAIN_NONE As Integer = 0
'	Public Const REPLAY_GAIN_ALBUM As Integer = 1
'	Public Const REPLAY_GAIN_TRACK As Integer = 2
'	Public Const XC_VIDEO_FLAGS As Integer = 8
'	Public Const MAX_RESOLUTIONS As Integer = 64
'	Public Const CACHE_AUDIO As Integer = 0
'	Public Const CACHE_VIDEO As Integer = 1
'	Public Const CACHE_VOB As Integer = 2
'	Public Const VOLUME_MAXIMUM As Integer = 0
'	Public Const VOLUME_DRC_MINIMUM As Integer = 0
'	Public Const VOLUME_DRC_MAXIMUM As Integer = 3000
'	Public Const VIEW_MODE_NORMAL As Integer = 0
'	Public Const VIEW_MODE_ZOOM As Integer = 1
'	Public Const VIEW_MODE_STRETCH_4x3 As Integer = 2
'	Public Const VIEW_MODE_STRETCH_14x9 As Integer = 3
'	Public Const VIEW_MODE_STRETCH_16x9 As Integer = 4
'	Public Const VIEW_MODE_ORIGINAL As Integer = 5
'	Public Const VIEW_MODE_CUSTOM As Integer = 6
'	Public Const STACK_NONE As Integer = 0
'	Public Const STACK_SIMPLE As Integer = 1
'	Public Const VIDEO_SHOW_ALL As Integer = 0
'	Public Const VIDEO_SHOW_UNWATCHED As Integer = 1
'	Public Const VIDEO_SHOW_WATCHED As Integer = 2
'	Public Const PROFILES_FILE As String = "t:\profiles.xml"
'#If PATH_SEPARATOR_STRING_AlternateDefinition1 Then
'	Public Const PATH_SEPARATOR_STRING As String = "\"
'#ElseIf PATH_SEPARATOR_STRING_AlternateDefinition2 Then
'	Public Const PATH_SEPARATOR_STRING As String = "/"
'#End If
'End Class

'Public Class CScraperParser
'	Public Sub ReplaceBuffers(ByRef strDest As std.map)
'	  ' insert buffers
'	  Dim iIndex As Integer
'	  For i As Integer = DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS-1 To 0 Step -1
'		GlobalMembersScraperParser.std.map< temp
'		iIndex = 0
'		temp.Format("$$%i", i+1)
'		iIndex = strDest.find(temp,iIndex)
'		Do While CUInt(iIndex) <> GlobalMembersScraperParser.std.map<npos ' COPIED FROM CStdString WITH THE ADDITION OF $ ESCAPING
'		  strDest.replace(strDest.begin()+iIndex,strDest.begin()+iIndex+temp.GetLength(),m_param(i))
'		  iIndex += m_param(i).length()
'			iIndex = strDest.find(temp,iIndex)
'		Loop
'	  Next i
'	  ' insert settings
'	  iIndex = 0
'	  iIndex = strDest.find("$INFO[",iIndex)
'	  Do While CUInt(iIndex) <> GlobalMembersScraperParser.std.map<npos AndAlso m_settings
'		Dim iEnd As Integer = strDest.Find("]",iIndex)
'		GlobalMembersScraperParser.std.map< strInfo = strDest.Mid(iIndex+6,iEnd-iIndex-6)
'		GlobalMembersScraperParser.std.map< strReplace = m_settings.Get(strInfo)
'		strDest.replace(strDest.begin()+iIndex,strDest.begin()+iEnd+1,strReplace)
'		iIndex += strReplace.length()
'		  iIndex = strDest.find("$INFO[",iIndex)
'	  Loop
'	  iIndex = 0
'	  iIndex = strDest.find("\n",iIndex)
'	  Do While CUInt(iIndex) <> GlobalMembersScraperParser.std.map<npos
'		strDest.replace(strDest.begin()+iIndex,strDest.begin()+iIndex+2,Constants.vbLf)
'		  iIndex = strDest.find("\n",iIndex)
'	  Loop
'	End Sub
'	Public Sub ParseExpression(ByVal input As std.map, ByRef dest As std.map, ByVal element As TiXmlElement, ByVal bAppend As Boolean)
'	  GlobalMembersScraperParser.std.map< strOutput = element.Attribute("output")

'	  Dim pExpression As TiXmlElement = element.FirstChildElement("expression")
'	  If pExpression IsNot Nothing Then
'		Dim reg As New CRegExp()
'		GlobalMembersScraperParser.std.map< strExpression
'		If pExpression.FirstChild() Then
'		  strExpression = pExpression.FirstChild().Value()
'		Else
'		  strExpression = "(.*)"
'		End If
'		ReplaceBuffers(strExpression)
'		ReplaceBuffers(strOutput)

'		If (Not reg.RegComp(strExpression.c_str())) Then
'		  Return
'		End If

'		Dim bRepeat As Boolean = False
'		Dim szRepeat As GlobalMembersScraperParser.String = pExpression.Attribute("repeat")
'		If szRepeat IsNot Nothing Then
'		  If String.Compare(szRepeat,"yes", True) = 0 Then
'			bRepeat = True
'		  End If
'		End If

'		Dim szClear As GlobalMembersScraperParser.String = pExpression.Attribute("clear")
'		If szClear IsNot Nothing Then
'		  If String.Compare(szClear,"yes", True) = 0 Then
'			dest ="" ' clear no matter if regexp fails
'		  End If
'		End If

'		Dim szNoClean As GlobalMembersScraperParser.String = pExpression.Attribute("noclean")
'		Dim bClean(DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1) As Boolean
'		For iBuf As Integer = 0 To DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1
'		  bClean(iBuf) = True
'		Next iBuf
'		If szNoClean IsNot Nothing Then
'		  List<GlobalMembersScraperParser.std.map(Of ) vecBufs
'		  CUtil.Tokenize(szNoClean, vecBufs, ",")
'		  For nToken As UInteger = 0 To vecBufs.size() - 1
'			bClean(Convert.ToInt32(vecBufs(nToken).c_str())-1) = False
'		  Next nToken
'		End If

'		Dim szTrim As GlobalMembersScraperParser.String = pExpression.Attribute("trim")
'		Dim bTrim(DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1) As Boolean
'		For iBuf As Integer = 0 To DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1
'		  bTrim(iBuf) = False
'		Next iBuf
'		If szTrim IsNot Nothing Then
'		  List<GlobalMembersScraperParser.std.map(Of ) vecBufs
'		  CUtil.Tokenize(szTrim, vecBufs, ",")
'		  For nToken As UInteger = 0 To vecBufs.size() - 1
'			bTrim(Convert.ToInt32(vecBufs(nToken).c_str())-1) = True
'		  Next nToken
'		End If

'		Dim iOptional As Integer = -1
'		pExpression.QueryIntAttribute("optional", iOptional)

'		Dim iCompare As Integer = -1
'		pExpression.QueryIntAttribute("compare", iCompare)
'		If iCompare > -1 Then
'		  m_param(iCompare-1).ToLower()
'		End If
'		GlobalMembersScraperParser.std.map< curInput = input
'		For iBuf As Integer = 0 To DefineConstantsScraperParser.MAX_SCRAPER_BUFFERS - 1
'		  If bClean(iBuf) Then
'			Dim temp As New GlobalMembersScraperParser.String(New Char(3){})
'			temp = String.Format("\{0:D}", iBuf+1)
'			Dim i2 As UInteger =0
'			i2 = strOutput.Find(temp, i2)
'			Do While i2 <> GlobalMembersScraperParser.std.map<npos
'			  strOutput.Insert(i2, "!!!CLEAN!!!")
'			  i2 += 11
'			  strOutput.Insert(i2+2, "!!!CLEAN!!!")
'			  i2 += 2
'				i2 = strOutput.Find(temp, i2)
'			Loop
'		  End If
'		  If bTrim(iBuf) Then
'			Dim temp As New GlobalMembersScraperParser.String(New Char(3){})
'			temp = String.Format("\{0:D}", iBuf+1)
'			Dim i2 As UInteger =0
'			i2 = strOutput.Find(temp, i2)
'			Do While i2 <> GlobalMembersScraperParser.std.map<npos
'			  strOutput.Insert(i2, "!!!TRIM!!!")
'			  i2 += 10
'			  strOutput.Insert(i2+2, "!!!TRIM!!!")
'			  i2 += 2
'				i2 = strOutput.Find(temp, i2)
'			Loop
'		  End If
'		Next iBuf
'		Dim i As Integer = reg.RegFind(curInput.c_str())
'		Do While i > -1 AndAlso (i < CInt(Fix(curInput.size())) OrElse curInput.size() = 0)
'		  If (Not bAppend) Then
'			dest = ""
'			bAppend = True
'		  End If
'		  GlobalMembersScraperParser.std.map< strCurOutput=strOutput

'		  If iOptional > -1 Then ' check that required param is there
'			Dim temp As New GlobalMembersScraperParser.String(New Char(3){})
'			temp = String.Format("\{0:D}", iOptional)
'			Dim szParam As SByte = reg.GetReplaceString(temp)
'			Dim reg2 As New CRegExp()
'			reg2.RegComp("(.*)(\\\(.*\\2.*)\\\)(.*)")
'			Dim i2 As Integer =reg2.RegFind(strCurOutput.c_str())
'			Do While i2 > -1
'			  Dim szRemove As SByte = reg2.GetReplaceString("\2")
'			  Dim iRemove As Integer = szRemove.Length
'			  Dim i3 As Integer = strCurOutput.find(szRemove)
'			  If szParam AndAlso String.Compare(szParam,"") Then
'				strCurOutput.erase(i3+iRemove,2)
'				strCurOutput.erase(i3,2)
'			  Else
'				strCurOutput.replace(strCurOutput.begin()+i3,strCurOutput.begin()+i3+iRemove+2,"")
'			  End If

'	'C++ TO VB CONVERTER TODO TASK: The memory management function 'free' has no equivalent in VB:
'			  free(szRemove)

'			  i2 = reg2.RegFind(strCurOutput.c_str())
'			Loop
'			If szParam Then
'	'C++ TO VB CONVERTER TODO TASK: The memory management function 'free' has no equivalent in VB:
'			  free(szParam)
'			End If
'		  End If

'		  Dim iLen As Integer = reg.GetFindLen()
'		  ' nasty hack #1 - & means \0 in a replace string
'		  strCurOutput.Replace("&", "!!!AMPAMP!!!")
'		  Dim result As SByte = reg.GetReplaceString(strCurOutput.c_str())
'		  If result AndAlso result.Length Then
'			GlobalMembersScraperParser.std.map< strResult(result)
'			strResult.Replace("!!!AMPAMP!!!", "&")
'			Clean(strResult)
'			ReplaceBuffers(strResult)
'			If iCompare > -1 Then
'			  GlobalMembersScraperParser.std.map< strResultNoCase = strResult
'			  strResultNoCase.ToLower()
'			  If CUInt(strResultNoCase.Find(m_param(iCompare-1))) <> GlobalMembersScraperParser.std.map<npos Then
'				dest += strResult
'			  End If
'			Else
'			  dest += strResult
'			End If

'	'C++ TO VB CONVERTER TODO TASK: The memory management function 'free' has no equivalent in VB:
'			free(result)
'		  End If
'		  If bRepeat Then
'			curInput.erase(0,If(i+iLen>CInt(Fix(curInput.size())), curInput.size(), i+iLen))
'			i = reg.RegFind(curInput.c_str())
'		  Else
'			i = -1
'		  End If
'		Loop
'	  End If
'	End Sub
'	Public Sub Clean(ByRef strDirty As std.map)
'	  Dim i As UInteger =0
'	  GlobalMembersScraperParser.std.map< strBuffer
'	  i =strDirty.Find("!!!CLEAN!!!",i)
'	  Do While i <> GlobalMembersScraperParser.std.map<npos
'		Dim i2 As UInteger
'		i2 =strDirty.Find("!!!CLEAN!!!",i+11)
'		If i2 <> GlobalMembersScraperParser.std.map<npos Then
'		  strBuffer = strDirty.substr(i+11,i2-i-11)
'		  GlobalMembersScraperParser.std.map< strConverted(strBuffer)
'		  HTML.CHTMLUtil.RemoveTags(strConverted)
'		  Dim szTrimmed As GlobalMembersScraperParser.String = RemoveWhiteSpace(strConverted.c_str())
'		  strDirty.erase(i,i2-i+11)
'		  strDirty.Insert(i,szTrimmed)
'		  i += szTrimmed.Length
'		Else
'		  Exit Do
'		End If
'		  i =strDirty.Find("!!!CLEAN!!!",i)
'	  Loop
'	  i =0
'	  i =strDirty.Find("!!!TRIM!!!",i)
'	  Do While i <> GlobalMembersScraperParser.std.map<npos
'		Dim i2 As UInteger
'		i2 =strDirty.Find("!!!TRIM!!!",i+10)
'		If i2 <> GlobalMembersScraperParser.std.map<npos Then
'		  strBuffer = strDirty.substr(i+10,i2-i-10)
'		  Dim szTrimmed As GlobalMembersScraperParser.String = RemoveWhiteSpace(strBuffer.c_str())
'		  strDirty.erase(i,i2-i+10)
'		  strDirty.Insert(i,szTrimmed)
'		  i += szTrimmed.Length
'		Else
'		  Exit Do
'		End If
'		  i =strDirty.Find("!!!TRIM!!!",i)
'	  Loop
'	End Sub
'	Public Function RemoveWhiteSpace(ByVal string2 As String) As String
'	  If string2 Is Nothing Then
'		  Return CSByte("")
'	  End If
'	  Dim GlobalMembersScraperParser.String As GlobalMembersScraperParser.String = CType(string2, [String])
'	  Dim pos As UInteger = [String].Length-1
'	  Do While (GlobalMembersScraperParser.String(pos) = " "c OrElse GlobalMembersScraperParser.String(pos) = ControlChars.Lf) AndAlso GlobalMembersScraperParser.String(pos) AndAlso pos <> 0
'		GlobalMembersScraperParser.String(pos) = ControlChars.NullChar
'		pos -= 1
'	  Loop
'	  Do While (*GlobalMembersScraperParser.String = " "c OrElse *GlobalMembersScraperParser.String = ControlChars.Lf) AndAlso *GlobalMembersScraperParser.String <> ControlChars.NullChar
'		GlobalMembersScraperParser.String += 1
'	  Loop
'	  Return GlobalMembersScraperParser.String
'	End Function
'End Class
