using UnityEngine;
using System.Collections.Generic;

class CharacterStat : MonoBehaviour
{
    //		Basic		//
    private static string _Occupation; // 직업
    private static int _Level = 1; // 레벨
    private static int _EXP = 0; // 현재 경험치
    private static int _MAXEXP; // 최대 경험치
    private static int _STR = 4; // 힘
    private static int _VIT = 4; // 체력
    private static int _LUK = 4; // 행운
    //		Detail		//
    private static int _HP = 20; // 현재 체력
    private static int _MAXHP = 20; // 최대 체력
    private static int _ATK = 8; // 물리 공격력
    //		Item		//
    private static string _WeaponName = "널브러진 대검"; // 장착중인 무기
    //		Add			//
    private static int _StatPoint = 0; // 스텟 포인트
    private static int _Slot = 0; // 현재 사용 칸
    private static int _Money = 0; // 소지금

    //		Basic		//
    // 직업
    public static string Occupation
    {
        get { return _Occupation; }
        set { _Occupation = value; }
    }
    // 레벨
    public static int Level
    {
        get { return _Level; }
        set { _Level = value; }
    }
    // 현재 경험치
    public static int EXP
    {
        get { return _EXP; }
        set { _EXP = value; }
    }
    // 최대 경험치
    public static int MAXEXP
    {
        get { return _MAXEXP; }
        set { _MAXEXP = value; }
    }
    // 힘
    public static int STR
    {
        get { return _STR; }
        set { _STR = value; }
    }
    // 체력
    public static int VIT
    {
        get { return _VIT; }
        set { _VIT = value; }
    }
    // 행운
    public static int LUK
    {
        get { return _LUK; }
        set { _LUK = value; }
    }
    //		Detail		//
    // 현재 체력
    public static int HP
    {
        get { return _HP; }
        set { _HP = value; }
    }
    // 최대 체력
    public static int MAXHP
    {
        get { return _MAXHP; }
        set { _MAXHP = value; }
    }
    // 물리 공격력
    public static int ATK
    {
        get { return _ATK; }
        set { _ATK = value; }
    }
    //		Item		//
    // 장착중인 무기
    public static string WeaponName
    {
        get { return _WeaponName; }
        set { _WeaponName = value; }
    }
    //		Add		//
    // 스텟 포인트
    public static int StatPoint
    {
        get { return _StatPoint; }
        set { _StatPoint = value; }
    }
    // 현재 사용 칸
    public static int Slot
    {
        get { return _Slot; }
        set { _Slot = value; }
    }
    // 소지금
    public static int Money
    {
        get { return _Money; }
        set { _Money = value; }
    }
}
