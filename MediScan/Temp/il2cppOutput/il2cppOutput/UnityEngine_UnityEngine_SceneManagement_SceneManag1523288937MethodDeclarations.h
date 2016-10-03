#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// UnityEngine.AsyncOperation
struct AsyncOperation_t3374395064;
struct AsyncOperation_t3374395064_marshaled_pinvoke;
// System.String
struct String_t;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_SceneManagement_LoadSceneM2068802481.h"
#include "mscorlib_System_String968488902.h"

// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.Int32)
extern "C"  void SceneManager_LoadScene_m193744610 (Il2CppObject * __this /* static, unused */, int32_t ___sceneBuildIndex0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.Int32,UnityEngine.SceneManagement.LoadSceneMode)
extern "C"  void SceneManager_LoadScene_m2455768283 (Il2CppObject * __this /* static, unused */, int32_t ___sceneBuildIndex0, int32_t ___mode1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.AsyncOperation UnityEngine.SceneManagement.SceneManager::LoadSceneAsyncNameIndexInternal(System.String,System.Int32,System.Boolean,System.Boolean)
extern "C"  AsyncOperation_t3374395064 * SceneManager_LoadSceneAsyncNameIndexInternal_m3775081569 (Il2CppObject * __this /* static, unused */, String_t* ___sceneName0, int32_t ___sceneBuildIndex1, bool ___isAdditive2, bool ___mustCompleteNextFrame3, const MethodInfo* method) IL2CPP_METHOD_ATTR;
