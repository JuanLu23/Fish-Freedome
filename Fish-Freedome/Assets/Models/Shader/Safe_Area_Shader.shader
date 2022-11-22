Shader "Unlit/Taller_1_Shader"
{
    Properties
    {
        _MyColor("My Color", Color) = (21, 90, 192, 1)
    }
        SubShader
    {
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM

            #pragma vertex VertexFunction
            #pragma fragment FragmentFunction


            float4 _MyColor;
            float4 _SecondaryColor;


            struct VertexData
            {
                float4 vertexPosition : POSITION;
                float2 uv : TEXCOORD0;
            };
            struct FragmentData
            {
                float4 vertexPosition : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            FragmentData VertexFunction(VertexData input)
            {
                FragmentData output;
                output.vertexPosition = UnityObjectToClipPos(input.vertexPosition);
                output.uv = input.uv;
                float4 f = mul(unity_ObjectToWorld, input.vertexPosition);
                return output;
            }
            float4 FragmentFunction(FragmentData input) : SV_TARGET
            {
                float4 finalColor;
                if (input.uv.x > 0.5 & input.uv.y > 0.5)
                {
                finalColor = _MyColor;
                }
                 return finalColor;
            }

            ENDCG
        }
    }
}