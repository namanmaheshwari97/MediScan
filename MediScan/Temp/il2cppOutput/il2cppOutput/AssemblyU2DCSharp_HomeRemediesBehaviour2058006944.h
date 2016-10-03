#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Button
struct Button_t990034267;
// UnityEngine.Canvas
struct Canvas_t3534013893;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// HomeRemediesBehaviour
struct  HomeRemediesBehaviour_t2058006944  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.UI.Button HomeRemediesBehaviour::HRbutton
	Button_t990034267 * ___HRbutton_2;
	// UnityEngine.Canvas HomeRemediesBehaviour::AR_MainCanv
	Canvas_t3534013893 * ___AR_MainCanv_3;
	// UnityEngine.Canvas HomeRemediesBehaviour::AR_HRCanv
	Canvas_t3534013893 * ___AR_HRCanv_4;

public:
	inline static int32_t get_offset_of_HRbutton_2() { return static_cast<int32_t>(offsetof(HomeRemediesBehaviour_t2058006944, ___HRbutton_2)); }
	inline Button_t990034267 * get_HRbutton_2() const { return ___HRbutton_2; }
	inline Button_t990034267 ** get_address_of_HRbutton_2() { return &___HRbutton_2; }
	inline void set_HRbutton_2(Button_t990034267 * value)
	{
		___HRbutton_2 = value;
		Il2CppCodeGenWriteBarrier(&___HRbutton_2, value);
	}

	inline static int32_t get_offset_of_AR_MainCanv_3() { return static_cast<int32_t>(offsetof(HomeRemediesBehaviour_t2058006944, ___AR_MainCanv_3)); }
	inline Canvas_t3534013893 * get_AR_MainCanv_3() const { return ___AR_MainCanv_3; }
	inline Canvas_t3534013893 ** get_address_of_AR_MainCanv_3() { return &___AR_MainCanv_3; }
	inline void set_AR_MainCanv_3(Canvas_t3534013893 * value)
	{
		___AR_MainCanv_3 = value;
		Il2CppCodeGenWriteBarrier(&___AR_MainCanv_3, value);
	}

	inline static int32_t get_offset_of_AR_HRCanv_4() { return static_cast<int32_t>(offsetof(HomeRemediesBehaviour_t2058006944, ___AR_HRCanv_4)); }
	inline Canvas_t3534013893 * get_AR_HRCanv_4() const { return ___AR_HRCanv_4; }
	inline Canvas_t3534013893 ** get_address_of_AR_HRCanv_4() { return &___AR_HRCanv_4; }
	inline void set_AR_HRCanv_4(Canvas_t3534013893 * value)
	{
		___AR_HRCanv_4 = value;
		Il2CppCodeGenWriteBarrier(&___AR_HRCanv_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
