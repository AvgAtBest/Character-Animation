Shader "Assets/Shaders/EthanShader"
{
	Properties
	{
		//variable name ("displayName", dataType) = value
		//DONT SEMI COLON
		_MainTexture("Diffuse Texture", 2D) = "white"{}//a 2D Texture
		//_Emission("Emission", 2D) = "white"{}
		_NormalTexture("Normal Texture", 2D) = "bump"{}
		_TintColour ("Tint", Color) = (0,0,0,0)
	}
	SubShader
	{
		Tags
		{
			"RenderType" = "Opaque"
		}
		//Semi colon from here
		CGPROGRAM
		#pragma surface test Lambert
		//connects the variableName to the CG code
		sampler2D _MainTexture;
		//sampler2D _Emission;
		sampler2D _NormalTexture;
		fixed4 _TintColour;
		struct Input
		{
		float2 uv_MainTexture;
		//float2 uv__Emission;
		float2 uv_NormalTexture;
		};
		
		void test(Input IN, inout SurfaceOutput o)
		{
			o.Albedo = tex2D (_MainTexture, IN.uv_MainTexture).rgb*_TintColour;
			//o.Emission = tex2D (_Emission, IN.uv_MainTexture).rgb;
			o.Normal = UnpackNormal(tex2D(_NormalTexture, IN.uv_NormalTexture));
		}
		ENDCG
		//No semi here
	}
	Fallback "Diffuse"
}
