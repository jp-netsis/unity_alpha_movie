# Unity Alpha Movie

## 🌐 Language

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![ja](https://img.shields.io/badge/lang-ja-blue.svg)](README.ja.md)

## Unity Version

**Unity 2022.3.45f1**

## Target Rendering Pipeline

- BuiltIn Render Pipeline
    - builtin_renderer_pipeline/BRP_Unity
- Universal Render Pipeline
    - unversal_renderer_pipeline/URP_Unity

Creating alpha channel videos in both cases is not recommended.

## Note

- Both are samples rendering the UI as videos with alpha channels.
- There is a possibility that either rendering pipeline may become unable to produce alpha channel videos due to Unity version updates.
- For creating videos with alpha channels, it is better to set the single color of the rendering to pure black.
- Rendering the UI in Space - Overlay will make it not appear on the camera, so the UI is rendered in Screen Space - Camera.
- For how to use Unity Recorder, please refer to this link.
- Recorder Settings:
    - Set the Codec in Output Format to VP8 WebM.
    - Don't forget to turn on the Include alpha setting.
- Built-in Rendering Pipeline Settings:
    - The Recorder specifies the Targeted Camera.
- Universal Rendering Pipeline Settings:
    - The Recorder specifies Texture Sampling.
    - Shader extensions were made to output the UberPost shader with alpha.
    - To change the shader of PostProcessData, a copy of the PostProcessData Scriptable Object was created and modified to create PostProcessDataAlpha.
    - To create videos with alpha channels using Unity Recorder, the Packages were extended and settings were changed to enable output with URP.