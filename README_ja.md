# Mondeto
[![Discord](https://img.shields.io/discord/776494294756360222?label=discord)](https://discord.gg/XKQtmT2XxP)

Languages | [English](README.md) | 日本語

オープン・柔軟・セキュアなオンラインVRシステム。

## 💡概要
**Mondeto**は次の3つの性質を持ったオンライン・マルチプレイヤーVRシステムです：
1. 📖**オープン：** Mondetoはサービスではなくオープンソースソフトウェアであり、誰もが自分のコンピュータで**サーバを立てることができます**。
2. 🛠️**柔軟：** [WebAssembly](https://webassembly.org/)を使って、VR空間内のオブジェクトを**プログラムから制御**できます。さらにMondeto本体を改造して**新しいハードウェアをVR世界と接続**することも可能です。
3. 🔒**セキュア：** 通信は**暗号化**されています。またWebAssemblyコードは**サンドボックス上**で安全に実行されます。オープン・柔軟でありながらセキュリティには妥協しません。

## 💻動作要件
- 64ビットのWindowsコンピュータ
- VRモードで使用する場合:
    - Oculus社製ヘッドセットとコントローラ（🙇他のヘッドセットに関しては現在対応作業中です🚧）
    - Oculusソフトウェアがインストールされていること

## 🚀使い方
### クライアント（既存サーバに接続する）
1. [リリースページ](https://github.com/tana/Mondeto/releases)からZipアーカイブをダウンロードし、適当なディレクトリに展開する。
    - もしくは、[mainブランチの（ほぼ）最新のビルド](https://1drv.ms/f/s!AvizOnmg-QO6hplqj7dZul1EnOJtcA)も使用可能です。
1. `Mondeto.exe`を起動する。
1. `Client`にチェックを入れる。    
    - デフォルトでは開発者が用意したサーバにつながるようになっていますが、ホスト名とポート番号を指定することで別のサーバにも接続できます。
1. `Start`ボタンを押すとサーバに接続できます。

操作方法は[こちら](https://github.com/tana/Mondeto/wiki/Controls) をご覧ください。

より高度な使い方に関しては、[本リポジトリのWiki](https://github.com/tana/Mondeto/wiki)をご参照ください。

## ✉️連絡先
ご不明な点がございましたら、[GitHub Discussions](https://github.com/tana/Mondeto/discussions)、[Discordチャット](https://discord.gg/XKQtmT2XxP)または[開発者のTwitter](https://twitter.com/tana_ash)でご質問ください。

## ⚖️ライセンス
Mondeto自体は[MIT License](LICENSE)でライセンスされています。
ただし、様々なライセンスのサードパーティプログラムやデータを利用しています（[credits/Credits.md](credits/Credits.md)を参照）。

さらに、本リポジトリは再配布可能なライセンスのもとでサードパーティプログラムやデータのいくつかを含んでいます。

## 🙏謝辞
本プロジェクトは[情報処理推進機構（IPA）](https://www.ipa.go.jp/)による[未踏IT人材発掘・育成事業](https://www.ipa.go.jp/jinzai/mitou/portal_index.html)の支援を受けています。