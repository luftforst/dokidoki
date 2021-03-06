/**
 *
 *  You can modify and use this source freely
 *  only for the development of application related Live2D.
 *
 *  (c) Live2D Inc. All rights reserved.
 */
using UnityEngine;
using System.Collections;

public class LAppDefine
{
	
    public static bool DEBUG_LOG = true;
    public static bool DEBUG_TOUCH_LOG = false;
	public static bool DEBUG_DRAW_HIT_AREA = false;
	
	
	
	public const float VIEW_MAX_SCALE = 2f;
	public const float VIEW_MIN_SCALE = 0.8f;
	
	public const float VIEW_LOGICAL_LEFT = -1;
	public const float VIEW_LOGICAL_RIGHT = 1;
	
	public const float VIEW_LOGICAL_MAX_LEFT = -2;
	public const float VIEW_LOGICAL_MAX_RIGHT = 2;
	public const float VIEW_LOGICAL_MAX_BOTTOM = -2;
	public const float VIEW_LOGICAL_MAX_TOP = 2;
	
	public const float SCREEN_WIDTH = 20.0f;
	public const float SCREEN_HEIGHT = 20.0f;
	


	// not use motion
	public const string MOTION_GROUP_FLICK_HEAD		="flick_head";
    public const string MOTION_GROUP_FLICK_BREAST   = "flick_breast";	
	public const string MOTION_GROUP_PINCH_IN		="pinch_in";	
	public const string MOTION_GROUP_PINCH_OUT		="pinch_out";	
	public const string MOTION_GROUP_SHAKE			="shake";
	
    // idle motion
	public const string MOTION_GROUP_IDLE			="idle";	
	
    // tap motion
	public const string MOTION_GROUP_TAP_BODY		="tap_body";	//가슴
	public const string MOTION_GROUP_TAP_HEAD		="tap_head";	//머리
	public const string MOTION_GROUP_TAP_HAND		="tap_hand";	//손
	public const string MOTION_GROUP_TAP_SHOULDER	="tap_shoulder";//어깨 왼쪽/오른쪽
	public const string MOTION_GROUP_TAP_THIGH		="tap_thigh";	//허벅지 
	public const string MOTION_GROUP_TAP_CENTER		="tap_center";	//거시기
	public const string MOTION_GROUP_TAP_STOMACH	="tap_stomach";	//복근

    //hit area	
	public const string HIT_AREA_BODY				="body";
	public const string HIT_AREA_HEAD				="head";
	public const string HIT_AREA_HAND_RIGHT			="hand_right";
	public const string HIT_AREA_HAND_LEFT			="hand_left";
	public const string HIT_AREA_SHOULDER			="shoulder";
	public const string HIT_AREA_THIGH_RIGHT		="thigh_right";
	public const string HIT_AREA_THIGH_LEFT			="thigh_left";
	public const string HIT_AREA_CENTER				="center";
	public const string HIT_AREA_STOMACH			="stomach";



	// new expreesion define
	public const string MOTION_GROUP_TALK           ="talk";
	public const string MOTION_GROUP_SERIOUS        ="serious";
	public const string MOTION_GROUP_SMILE          ="smile";
	public const string MOTION_GROUP_ANGRY          ="angry";
	public const string MOTION_GROUP_SHAME          ="shame";



	public const int PRIORITY_NONE			= 0;
	public const int PRIORITY_IDLE			= 1;
	public const int PRIORITY_NORMAL		= 2;
    public const int PRIORITY_FORCE         = 3;
}