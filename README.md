# MAUI_TEST

Problem: 
Page3 don't returns to Page2 and throws exception. Relative routes don't work, but absolute ones do.

How to trigger:
1. In AppShell.xaml.cs comment *//Works block* and decomment *//Doesn't works*.
2. Build app and click buttons `Next -> Next -> Back`

Error:
`System.ArgumentException: 'Ambiguous routes matched for: //IMPL_MainPage/IMPL_MainPage/MainPage/NewPage1 matches found: //IMPL_MainPage/IMPL_MainPage/MainPage/NewPage1,//IMPL_MainPage/IMPL_MainPage/MainPage/NewPage1 (Parameter 'uri')'`

Call Stack:
![Screenshot_1](https://github.com/nick4real/MAUI_TEST/assets/67540024/fc4075f0-b50c-473b-bdcf-2879a5eb1443)
