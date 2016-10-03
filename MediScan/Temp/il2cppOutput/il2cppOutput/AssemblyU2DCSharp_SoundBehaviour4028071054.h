#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.RawImage
struct RawImage_t3831555132;
// UnityEngine.UI.Button
struct Button_t990034267;
// UnityEngine.Texture
struct Texture_t1769722184;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SoundBehaviour
struct  SoundBehaviour_t4028071054  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.UI.RawImage SoundBehaviour::buttonIMG
	RawImage_t3831555132 * ___buttonIMG_2;
	// UnityEngine.UI.Button SoundBehaviour::soundBtn
	Button_t990034267 * ___soundBtn_3;
	// System.Int32 SoundBehaviour::pref
	int32_t ___pref_4;
	// UnityEngine.Texture SoundBehaviour::soundOn
	Texture_t1769722184 * ___soundOn_5;
	// UnityEngine.Texture SoundBehaviour::soundOff
	Texture_t1769722184 * ___soundOff_6;

public:
	inline static int32_t get_offset_of_buttonIMG_2() { return static_cast<int32_t>(offsetof(SoundBehaviour_t4028071054, ___buttonIMG_2)); }
	inline RawImage_t3831555132 * get_buttonIMG_2() const { return ___buttonIMG_2; }
	inline RawImage_t3831555132 ** get_address_of_buttonIMG_2() { return &___buttonIMG_2; }
	inline void set_buttonIMG_2(RawImage_t3831555132 * value)
	{
		___buttonIMG_2 = value;
		Il2CppCodeGenWriteBarrier(&___buttonIMG_2, value);
	}

	inline static int32_t get_offset_of_soundBtn_3() { return static_cast<int32_t>(offsetof(SoundBehaviour_t4028071054, ___soundBtn_3)); }
	inline Button_t990034267 * get_soundBtn_3() const { return ___soundBtn_3; }
	inline Button_t990034267 ** get_address_of_soundBtn_3() { return &___soundBtn_3; }
	inline void set_soundBtn_3(Button_t990034267 * value)
	{
		___soundBtn_3 = value;
		Il2CppCodeGenWriteBarrier(&___soundBtn_3, value);
	}

	inline static int32_t get_offset_of_pref_4() { return static_cast<int32_t>(offsetof(SoundBehaviour_t4028071054, ___pref_4)); }
	inline int32_t get_pref_4() const { return ___pref_4; }
	inline int32_t* get_address_of_pref_4() { return &___pref_4; }
	inline void set_pref_4(int32_t value)
	{
		___pref_4 = value;
	}

	inline static int32_t get_offset_of_soundOn_5() { return static_cast<int32_t>(offsetof(SoundBehaviour_t4028071054, ___soundOn_5)); }
	inline Texture_t1769722184 * get_soundOn_5() const { return ___soundOn_5; }
	inline Texture_t1769722184 ** get_address_of_soundOn_5() { return &___soundOn_5; }
	inline void set_soundOn_5(Texture_t1769722184 * value)
	{
		___soundOn_5 = value;
		Il2CppCodeGenWriteBarrier(&___soundOn_5, value);
	}

	inline static int32_t get_offset_of_soundOff_6() { return static_cast<int32_t>(offsetof(SoundBehaviour_t4028071054, ___soundOff_6)); }
	inline Texture_t1769722184 * get_soundOff_6() const { return ___soundOff_6; }
	inline Texture_t1769722184 ** get_address_of_soundOff_6() { return &___soundOff_6; }
	inline void set_soundOff_6(Texture_t1769722184 * value)
	{
		___soundOff_6 = value;
		Il2CppCodeGenWriteBarrier(&___soundOff_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
