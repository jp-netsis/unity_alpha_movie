# Unity Alpha Movie

## 🌐 言語

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![ja](https://img.shields.io/badge/lang-en-blue.svg)](README.ja.md)

## Unity バージョン

**Unity 2022.3.45f1**

## ターゲットレンダリングパイプライン

- BuiltIn Render Pipeline
    - builtin_renderer_pipeline/BRP_Unity
- Universal Render Pipeline
    - unversal_renderer_pipeline/URP_Unity

## ノート

- どちらもUIをアルファ付き動画としてレンダリングするサンプルです。
- どちらのレンダリングパイプラインもUnityのバージョンアップによってアルファ付き動画制作ができなくなる可能性があります。
- アルファ付き動画制作の際はレンダリングの単色は真っ黒にしたほうが良いでしょう。
- UIを Space - Overlay でレンダリングするとカメラに描画されなくなるため、UIは Screen Space - Camera で描画しています。
- Unity Recorder の使用方法は [こちら](https://docs.unity3d.com/Packages/com.unity.recorder@4.0/manual/index.html) をごらんください
- Recorder の設定ポイント
    - Output Format の Codec は VP8 WebM にしてください
    - Include alpha の設定をONにすることを忘れないでください
- ビルトインレンダリングパイプラインの設定ポイント
    - Recorder は Targeted Camera を指定しています。
- ユニバーサルレンダリングパイプラインの設定ポイント
    - Recorder は Texture Sampling を指定しています。
    - UberPost シェーダーを Alpha 付きで出力するようシェーダー拡張を行い設定しました。
    - PostProcessData のシェーダーを変えるため PostProcessData の Scriptable Objectをコピーし変更し PostProcessDataAlpha を作成しました。
    - Unity Recorder でアルファ付き動画を作成するため、Packages を拡張しURPで出力できるよう設定を変更しました。
