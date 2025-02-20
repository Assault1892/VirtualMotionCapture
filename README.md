# バーチャルモーションキャプチャー (VirtualMotionCapture)  
VRゲーム中にモデルをコントロール  
  
VRMのモデルファイルを読み込んで、3点～10点フルトラッキングで操作するアプリです。  
追加のモーションキャプチャーがなくても、動いている姿を見せることができます。  
もちろんVRゲーム中以外でも使用することができます。  
  
  
**[公式ホームページはこちらです](https://sh-akira.github.io/VirtualMotionCapture/)**  
**ダウンロード、説明書、よくある質問等すべてこちらからご覧ください。**  
  
  
# VRゲーム中にも同時起動可能  
  
通常のUnityアプリと違い、VRゲームと同時起動ができます。  
HMDと両手コントローラーのみ、  
HMDと両手コントローラーと腰トラッカー、  
HMDと両手コントローラーと両足トラッカー、  
HMDと両手コントローラーと腰と両足トラッカー  
これらにプラスして両肘トラッカー、両膝トラッカー、
それぞれのキャリブレーションに対応しています。  
全ての部位にHMD、コントローラー、トラッカーを自由に割り当て可能です。  
  
# 基本の操作方法  
起動するとコントロールパネルが表示されます。  
VRMモデル読み込みを押して、任意のVRMモデルを読み込んでください。  
モデルのライセンスが表示されますので、問題なければ同意しますを押してください。  
その後、モデル読み込みウインドウを閉じて、キャリブレーションボタンを押します。  
画面の指示通りに進めてください。  
デフォルトのキー設定はHTC Vive用になっていますので、  
Oculus Touchをお使いの場合はショートカットキー設定を開き、  
プリセットをOculusの物に変更してください。  
VRoid製のモデルを使用する場合、リップシンクが表情と競合しますので  
同様にショートカットキー設定を開き、VRoidのプリセットを使用してください  
  
モデルが表示されている画面をマウスで操作するとカメラがコントロールできます。  
ホイール：ズーム  
右クリック＋ドラッグ：カメラの移動  
左クリック＋ドラッグ：ウィンドウの移動  
  
# ダウンロード
ダウンロードページ：[https://sh-akira.booth.pm/items/999760]  
ダウンロードページかリリースページからVirtualMotionCapture0.xx.zipをダウンロードしてください。  
解凍後VirtualMotionCapture.exeを実行で開始します。  

[avast アバスト無料アンチウイルスにブロックされる場合はこちらをご覧ください](https://github.com/sh-akira/VirtualMotionCapture/blob/master/documents/avast.md)
  
    
    
テスト環境：  
OS: Windows 10 (1809)  
CPU:Core i9 9900k  
GPU: Geforce RTX2080Ti  
Mem: 16GB  
VR: HTC Vive + 11 tracker  
(Oculus Rift+Touchの3点と+Kinectでの6点での動作報告があります)  
(GTX1080 での動作も確認済み)  
(Vive Pro,i7-4790K,GTX980,Mem 8G, Win10 Proで動作確認されました)  
WinMR機器での動作確認もされています(必ず両手のコントローラーが必要です。キャリブレーション時に両手がトラッキングされている必要があります)  
また、WinMRの場合Tポーズが通常の方法では取れませんがカウントダウンの0秒時に一気に腕を開くことで疑似的にTポーズをとる必要があります  
Oculus Rift Sの動作確認済みです  
  
  
まだテスト版です。テストが不十分の可能性が大いにあります。  
何か問題があった際は、Twitterでお問い合わせください。  
動作環境スペック報告もお待ちしています。  
[@sh_akira](https://twitter.com/sh_akira)  
  
  
  
# 更新履歴
Ver 0.50  
・Modに対応しました。詳細はこちら： http://mod.vmc.info/  
・Debug Log画面が詳細設定に追加されました。  
・VMCProtocolで手のボーン受信に対応(thx: @大福らな )  
・CameraPlusの新しいjsonフォーマットに対応 (thx: @snow )  
・表情ごとにBlendShape受信無効設定追加 (thx: @Reiya )  
・ばもきゃ本体終了時コンパネも閉じるように (thx : @junT58 )  
・トラッキング停止のチェックが画面を開きなおしたときに外れている問題の修正(thx: @junT58 )  
・カラースペースがガンマからリニアになりました  
・わきの締め具合を調整できるようにしました  
・/VMC/Ext/Remoteコマンドに対応しました  
・/VMC/Ext/Camの受信をlocalにしました  
・VMTを自動キャリブレーションから除外するように  
・タッチパッド/スティック設定画面に番号を表示するように  
・写真撮影機能に連続撮影機能が追加されました  
・腕を体に近づけると暴れる問題修正  
・VMCProtocol受信ポートが他のアプリと被った時の処理を修正  
・Alt押しながらホイール回転で滑らかなズーム機能追加  
・タッチパッドとスティックを両方使うとうまく動かない問題修正  
・透過保存されない問題修正 / 枠の非表示が保存されない問題修正  
・Skeletalのチェックが閉じて開くとまたついてしまう問題修正  
・MIDIインプットを有効化するチェックボックスを詳細設定に追加  
・設定ファイル読み込み時VRMファイルが存在しない場合も続行できるように  
・UnityMemoryMappedFileのチューニングでより操作の反応が早くなりました  
・OpenVR.Compositorが無い時のエラー抑制  
  
Ver 0.49  
・キャリブレーション時、モデルによって手首が180度捻じれていた問題修正  
・通常モードでのキャリブレーション時にコライダーサイズがおかしかった問題修正  
・カメラのミラーが効かなかった問題修正  
・カメラのレンダリングが2回行われていた問題修正  
・Post Processingとミラーが同時に動かなかった問題修正  
・設定読み込み時カメラのFOVがおかしかった問題修正  
・手の向きを自由に設定できるようになりました(BeatSaberのCONTROLLERS設定相当)  
・ショートカットキープリセットのBlendShape大文字小文字修正(すでに作成済みのプリセットは変換されません)  
・トラッキングの一時停止オプション追加(解除時スムーズに戻ります)  
・VIVE Pro EyeボタンにDroolon F1の記載を増やしました  
・VIVE Pro EyeとVIVE LipTrackerそれぞれにオンオフのチェックが増えました(デフォルトオフなので使用される方はオンにしてください)  
・VIVESRが無いと起動しない場合がある問題解決  
・強制的に立ち上がっていたSRanipalはオンにするまで立ち上がらなくなりました  
・DMM VR Connectが正しく動作しなかった問題修正  
・DMM VR Connectでロード後のキャリブレーションが正常にできなかった問題修正  
・DMM VR Connectで正常にロード後に不要なウィンドウが閉じるように  
  
Ver 0.48  
・デバイス探索対応  
　・(探索要求)wiadayoなどに見つけてもらう  
　・(探索受付)Oredayo4V, 4Mなどを見つける  
・見た目タブにAdvanced Graphics Optionが追加されました  
　・PostProcessing機能を追加しました  
　・環境光をオフにできる機能を追加しました  
・VIVE SRanipal SDKをv1.3.1.1に更新しました  
　・Droolon F1に対応しました  
・Tobii SDKを4.0.6に更新しました  
　・Tobii Eye Tracker 4Cと5に対応しています  
・UniVRM0.62.0に更新しました  
　・BlendShapeの大文字小文字が区別されるようになりました  
　・VMCProtocolで送信されるBlendShape名も区別されます  
　・設定ファイルの大文字は自動変換されます  
・DMM VR Connectに対応しました。Connectで使用中のアバターに設定したモデルをロード出来ます  
　・https://connect.vrlab.dmm.com/  
  
Ver 0.47  
・バーチャルモーショントラッカー(VMT)を搭載。  
　カメラ位置に常に追従する仮想トラッカー機能です。  
　LIVと組み合わせて簡単にカメラの制御ができます。  
・VMT使用時にフリー、バック、フロント、座標追従の  
　全てのカメラでLIVと完全な合成が出来るようになりました。  
・カメラ移動のスムージングオプション追加  
・LIVとの遅延調整用のWebカメラのバッファリング数が0～3から0～6に増えました。  
・waidayoを使用したパーフェクトシンクに対応  
・VMCProtocol v2.9 /VMC/Ext/Light(外部からのライト制御)に対応  
・requireHmd=false設定でHMDが無い状態でも正常起動するように修正  
・仮想WebCamインストール時に自動で有効になるように  
・英語設定時に画面がはみ出していた問題修正  
・背景色透過時ウインドウが透けなかった問題修正  
・枠の非表示時にモデルが縦に伸びていた問題修正  
・設定読み込み時に枠の非表示が効かなかった問題修正  
・アイトラッキング/リップトラッキング無しでビルド出来なかった問題修正  
・仮想カメラの出力先が無い時の警告抑制  
・一部メッセージを修正  
・デフォルトショートカットキープリセットから背景色キー削除  
・高解像度写真撮影機能が正しく描画できなかった問題修正  
  
Ver 0.46  
・VIVE Lip Tracker に対応しました  
・Unity 2019.4.8f にアップデートしました  
・SteamVR Pluginを2.6.1にアップデートしました  
・actions.json等のjsonファイルが移動されてフォルダが綺麗になりました  
・common.json等の設定ファイルがSettingsに移動しました  
  
Ver 0.45  
・VMCProtocol /VMC/Ext/Set/Eyeの座標を絶対座標からHeadからの相対座標に変更  
　(waidayoからの目線取得時に正しい方向になるように修正)  
・VMCProtocol受信機能(waidayo等)が無料版で使用できるようになりました  
・Unity側でエラー発生時にコントロールパネル下部ステータスバーに表示されるように  
　(ダブルクリックでエラーメッセージのコピーが出来ます)  
・WinMRコントローラー用のデフォルトバインディングを追加(thx TOMさん @tonyiduo)  
・複数立ち上げて同時にキャリブレーションした際にコントロールパネルが不正終了する問題修正  
・Vive Pro Eye非接続時にトラッキングしない様に修正  
・Tobii Eye Tracker 4Cがトラッキング範囲外の時に動作しない様に修正  
・VRがインストールされてないPCで実行した時のエラーを修正  
・MIDICCの合成の修正  
・LookAtBlendShapeの修正  
・左右コントローラーのボタンが途中で入れ替わってしまう問題への対処  
・ステータスバーをダブルクリックでエラーのトレースログが取得できるように  
・UIデザイン調整  
・コントロールパネルに説明書へのリンクを入れたヘルプタブが追加されました  
・Unity側で致命的なエラーが1万回発生した場合強制終了するように(毎フレーム出た場合約3分)  
・詳細設定画面の英語表記だった設定項目が日本語になりました(他の言語は全て英語表記)  
・OSC送信欄がVMCProtocol表記に変更になりました  
  
Ver 0.43  
・キャリブレーション画面の選択肢を大きくして押しやすく  
・最後のキャリブレーションの選択肢を記憶するように  
・キャリブレーション完了時に音を鳴らせるように  
・自動まばたき無効設定時にViveProEyeのまぶたの動きも同期しない様に変更  
・externalcamera.cfgの 開く/出力 を 読み込み/書き出し に文言変更  
・まばたき中にまばたき無効の表情に変更した時表情が壊れる問題修正  
・ゲームパッドを認識しない様に修正(thx:gpsnmeajp)  
・OSC送信で右手中指以降のボーン情報が正しく送信されない場合がある問題修正(thx:umiyuki)  
・OSCで仮想トラッカーの入力が動かなかった問題修正(thx:gpsnmeajp)  
・VRMLookAtHeadBlendShapeApplyer使用時に正しく適用、転送できていなかった問題修正  
・OSC受信で/VMC/Ext/Set/Eyeの受信を続けると重くなる問題修正  
・2回目以降のモデル読み込みでBlendShapeが動かなくなる問題修正  
・一部部位のトラッカーが有効になっている際にキャリブレーションできない問題修正  
  
Ver 0.42  
・コントローラーをトラッカーとして認識させるモード追加　（B-grip等の特殊持ちでのキャリブレーション想定）  
・前回設定保存していた際は起動時にdefault.jsonではなく前回読み込んだ設定ファイルパスから自動ロードするように  
・各ファイルを開くダイアログの初期フォルダをそれぞれ別々に保存  
・アンチエイリアス強度設定追加  
・詳細設定画面にローカルIP確認ボタン追加  
・pixivFANBOX,Patreonへのリンク(無料版のみ)  
・2回目以降のキャリブレーションでひざの方向がおかしくなったり　捻じれたりする問題修正  
・2回目以降のキャリブレーションでフロント、バック、座標固定　カメラが追従しなくなる問題修正  
・デフォルトでNEUTRALの表情を正しく表示できるように  
・まばたき時に現在の表情を消さずに合成するように  
・リップシンクの表情AIUEOを現在の表情と合成するように  
・足トラッカーが無い時腰が下がってしまう問題修正  
・トラッカー情報がすべて同時に消えた時にリストに残ってしまう　問題修正  
・背景球体のサイズを100から1000に拡大  
・英語言語パックのtypo修正  
・子画面を開いてる時に親画面を選択できないように修正  
・デバッグ時の設定画面の同期外れ修正  
・特定の状況でログが大量に出力されるのを抑制  
・基本の表情が正しく動いていなかったのを修正  
・デフォルト表情設定をNEUTRALに戻したとき動かないのを修正  
・表情の合成方法を作りなおしました。  
・ベースの表情、リップシンク、まばたき、EVMC4U全てが正しく合成されるようになりました  
・リップシンクが前のフレームの口と混ざり破綻する場合があったのを修正  
・デフォルト表情設定時もまばたきが有効になりました  
  
Ver 0.41  
・一部モデルで腰が捻じれていた問題修正  
・Standardシェーダーの表示修正  
・ひざボーン処理無効オプション追加  
・まばたき無効時のリセットを1回に変更  
・リップシンクを独立したBlendShape設定から合成に変更  
・ハンドジェスチャーの編集時の問題修正  
　・角度制限外の数値の際にデフォルトで制限オフになるように  
　・設定時の名称が再上書きでカスタムに書き換わっていたのを修正  
  
Ver 0.40  
・トラッカー飛びフィルター追加  
・SteamVR無しでもOSCの仮想トラッカーのみで動作するように  
・OSC機能追加  
　・送信周期設定に0を設定すると送信しないように  
　・デバイスのローカル座標も送信するように  
  
Ver 0.39  
・腰の動作の修正(腰が前に突き出たり猫背になったり首が前に出たりしなくなりました)  
  
Ver 0.38   
・MIDI入力対応(ショートカットキー設定)  
・MIDI CC入力対応(アナログ値でBlendShape操作)  
・MIDI入力外部送信対応  
・ViveSR API更新(thx:m2wasabi)  
・Oculus TouchのBinding修正(thx:rennosuke)  
・OSC機能追加：  
　・送信周期設定追加  
　・トラッカーの生データ送信対応(全てのトラッカーの位置情報送信)  
　・トラッカーの生データ受信対応(別のばもきゃからトラッカーデータを受信して動作可能)  
　・MIDI入力対応(外部からキーコードを使わずにショートカット操作可能)  
　・カメラ操作対応(外部からOSCで直接フリーカメラの位置を変更可能)  
　・表情操作対応(外部からOSCで表情のBlendShapeを直接操作可能)  
　・視線操作対応(外部から視線のターゲット位置を直接操作可能)  
   
Ver 0.37  
・中国語対応　翻訳:SoldierCHEF([@PoctorXz](https://twitter.com/PoctorXz))  
・韓国語対応　翻訳:MANKALO([@MANKALO_kr](https://twitter.com/MANKALO_kr))  
・OSC(モーション送信機能)関連の更新  
　OSCのアドレスとポート設定追加  
　OSCでモデルのスケール送信  
　OSCでカメラ位置の送信  
　OSCでコントローラーイベント送信  
　OSCでキーボードイベント送信  
・Valve IndexのSkeletal(自動で指を動かす機能)をデフォルトでオンに修正  
・空のショートカットキープロファイル追加(新しくまっさらなキー設定から設定を始められるように)  
  
Ver 0.36  
・OSCでバーチャルモーションキャプチャーのリアルタイムモーションデータを外部に送信できるように  
・VIVE Pro Eyeのまぶたの動きを使う設定のチェックが正しく保存されなかった問題修正  
  
Ver 0.35  
・Skeletal Input対応(Valve Index, Vive, Oculus, その他)全てのコントローラーで指が自動で動きます  
・タッチパッドとスティックを別の設定に分離(Index等の二つ付いたコントローラーでも全ての機能が割り当てられます)  
・キープリセット保存時、分割数も保存するように  
・ショートカットキー設定にSkeletal Inputを使うチェックボックス追加(チェックを外せば従来の操作で指が動きます)  
・CameraPlus(BeatSaberのMOD)の設定ファイルを入出力できます(LIV無しで位置合わせが可能に)(RoomAdjustは非対応)  
  
Ver 0.34  
・VIVE Pro Eyeサポート  
  
Ver 0.33  
・Tobii Eye Tracker 4Cサポート  
・UniVRM 0.53に更新  
  
Ver 0.32  
・CPU使用率を大幅に下げました  
・VRM読み込み時のファイルを開くダイアログが裏に行くときがある  
・設定読込/保存時のダイアログも裏に行く  
・[VRoid Hub]自分のモデルでも設定次第ではライセンス表記必須のメッセージが出てしまう  
・[VRoid Hub]VRoid Hubで探すボタンのリンク先をアプリページに変える  
・ロケーションによってexternalcamera.cfgのフォーマットに準拠しないファイルが生成される（ドットがカンマになる）  
・トラッカーオフセット設定を左右を連動してバーを動かす  
・設定保存に解像度も含める  
  
Ver 0.31  
・ライトの方向変更機能追加  
・ライトの色変更機能追加  
・しばらく使うとトラッカー選択が白くなる現象の修正  
  
Ver 0.30  
・フロント/バックカメラのブレ修正  
・フロント/バックカメラ移動がZ軸で回っていたのを修正  
  
Ver 0.29  
・フロントカメラの挙動修正(テスト版)  
  
Ver 0.28  
・モデル表示画面とコントロールパネルのアイコンを分けました  
・externalcamera.cfgの出力と設定保存をキャリブレーション前に行った場合に次の起動で設定を読み込むとカメラ位置がずれていた問題を修正  
・キャリブレーション時のモデルの手のひらを正しい方向(正面)に変更  

Ver 0.27  
・アイコン追加  
・ボタンのスタイル変更  
・再キャリブレーション時のコライダーサイズ修正  
・Final IKを1.8に更新  
・OVRLipSyncを1.30.0に更新  
・UniVRMを0.51に更新  
・[VRoid Hub]貼り付けボタン追加  
・[VRoid Hub]プラグイン0.16更新  

Ver 0.26  
・VRMを開く前に読み込みボタンを押すと固まる問題修正  
・2個以上トラッカーがあって足にトラッカー設定しない場合足が動かない問題修正  
・キャリブレーション後に手首の捻じれ補正が効かなかった問題修正  
・2回以上キャリブレーションを同じモデルで行うと手が入れ替わったりずれたりした問題修正  
  
Ver 0.25  
・VRoid Hubからのモデル読み込みに対応  
・キャリブレーション時にモデルをリロードしないように変更  
・UniVRM0.49対応  
・ローカルVRMを1度も読まずにVRoidHubからモデルを開くとキャリブレーションできなかった問題修正  
  
Ver 0.24  
・物理トラッカーへのexternalcamera.cfgの出力修正  
・モデル表示画面とコントロールパネルの通信方法を変更  
・v0.22からのOculusの認識修正  
  
Ver 0.23  
・FOV変更した設定データを起動直後に読み込むとカメラ位置が壊れる  
・設定読み込み直後の読み込み完了前に再度設定を読み込むとモデルが2体表示される  
  
Ver 0.22  
・画面の透過機能修正  
・OBSで複数起動キャプチャ対応のため、ウインドウタイトルに数字を追加  
・SteamVR起動後の後から起動に対応(最初に起動しなくて良くなりました)  
・キー設定でキーボード入力が正しく動くようになりました  
・マウスホイールでのカメラのズームがウインドウ外で発生しないように修正  
・新しいカメラ操作(Alt+左クリックドラッグ)の注視点を中心に回転を追加  
・カメラのFOV変更機能追加  
・externalcamera.cfg出力後にカメラの移動が出来ないように修正  
・写真撮影機能(高解像度/背景透過対応)追加  
・同じ名称のトラッカーが複数表示される問題修正  
  
Ver 0.21  
・トラッカー割り当て設定時のドロップダウン内も動かしたトラッカーが緑色になるように  
・externalcamera.cfgインポートのコントローラーやトラッカーを番号ではなく名前で選択できるように  
・externalcamera.cfgの出力機能追加  
・タイトルバーにバージョン番号の表示を追加  
・キャリブレーション時にLIVと名のついたコントローラーを除外するように  
  
Ver 0.20  
・キャリブレーション時にトラッカーの位置を白い球で表示  
・MR合成用の新しい二つのキャリブレーションを追加  
  
Ver 0.19  
・UniVRM0.45に対応  
・UnityCaptureとVMC_Cameraが競合していたのを修正  
・キャリブレーションをexternalcamera.cfgでずれないように修正  
  
Ver 0.18  
・ひじ/ひざのトラッキング  
・モデルのひざボーンの方向を自動修正  
・仮想Webカメラ機能追加  
・フルトラ時(ひざ無し)のひざ方向修正  
・肩の回転修正  
・過去のVRoid読み込み  
・リップシンクデバイス未選択時タブを警告色  
・メニューの日本語変換ミス修正  
・VRM読み込みUIに長文が入るとレイアウト崩れる問題修正  
  
Ver 0.17  
・起動後の操作でフリーズする問題修正  
・UniVRM 0.44に更新  
・VRoid向けNormalMap修正オプション削除  
  
Ver 0.16  
・膝が内側に曲がる  
・映像左右反転  
・English version  
・キャリブレーション時VRoidテカテカ  
・トラッカー4つ以上  
・頭だけ動かしたときにSpringBoneが動いてない  
  
Ver 0.15  
・NormalMapのテカテカ再度修正(VRoid v0.2.12向け)  
・OVRLipSyncを1.28に更新  
  
Ver 0.14  
・NormalMapのテカテカ修正(主にVRoid向け)  
・スケール変更時のコライダー修正  
  
Ver 0.13  
・手の角度調整が動かなくなっていたので修正  
・デフォルト-90,-90が0,0に変更になっています  
・手のトラッカーオフセット設定が正しく動いていなかったので修正  
  
Ver 0.12  
・頭、両手、腰、両足すべてのトラッカーを自由に選択できるようになりました  
・座標追従カメラを追加しました  
・UniVRMを0.43に更新  
  
Ver 0.11  
・キャリブレーション(頭と腰のスケール)修正  
・手首のねじれが起きないように補正するように  
・コントローラーの手首位置オフセットを少し修正  
・ハンドジェスチャーを設定時間アニメーションするように  
・足のトラッカーがない場合(3点や４点トラッキング)の時の歩幅や開き具合を調整  
・4点トラッキング(腰追加時)のフロント/バックカメラの追尾位置修正  
・ハンドジェスチャー設定時にVRoidモデルの手が画面に入りきらない問題修正  
・表情設定にリップシンク抑制追加(口を開けた表情/VRoid向け)  
・キャリブレーション開始時複数回トリガー押せないように  
・Oculus Touchのキャリブレーション開始トリガー修正  
・UniVRMを0.42に更新  
  
Ver 0.10  
・キャリブレーションの処理を変更しモデルのスケールをコントローラー位置にスケーリングするように  
・Oculus Touchの入力とプリセットを追加  
・キーの同時押しをしながら一部キーを離したときの処理を修正  
  
Ver 0.09  
・Oculus Touch確認のためにログ出力を入れた(テスト版)  
  
Ver 0.08  
・Oculus Touchの入力を暫定で入れた  
  
Ver 0.07  
・externalcamera.cfgの設定先コントローラー変更に対応  
・カメラが近づいたときに顔が非表示になってしまう時がある問題修正  
  
Ver 0.06  
・externalcamera.cfgファイルの読み込みに対応  
  
Ver 0.05  
・ショートカットキー機能  
・ハンドジェスチャー設定  
・表情設定  
・機能キー設定  
・手の角度の補正機能  
・キャリブレーション時にコントローラーのトリガーで開始できるように  
・UIをWinFormsからWPFの別アプリに変更  
・自動まばたきが完全に閉じなかったり開かなかったりする問題修正  
・使用しているVRIKCalibrator.csが直接編集されてしまっていたので修正  
  
Ver 0.04  
・自動まばたき機能追加(まばたきの細かいアニメーション時間設定ができます)  
・デフォルトの表情変更追加  
  
Ver 0.03  
・リップシンクに対応しました(低遅延・動きの設定が可能)  
・カメラのグリッド表示に対応  
・ウインドウのマウス操作の透過(透過ウインドウ時に下のウインドウを操作できるように)  
  
Ver 0.02  
・バーチャルモーションキャプチャー(命名:[ねこます](https://twitter.com/kemomimi_oukoku)さん)にすべて名称変更  
・設定読み込み時にチェックボックスが反映されない問題修正  
・設定保存時に選択中のカメラを保存するように  
・HMDと両手コントローラーと腰トラッカーのみ使用時、地に足付かなかった問題修正  
・ウィンドウをドラッグで移動時に初回の座標が飛ぶ問題修正  
・カメラの移動速度の感度を調整  
  
  
# ビルド手順  
ビルド環境：Unity 2019.4.8f1 / Visual Studio 2019 (Windowsデスクトップ開発パッケージ)  
  
  
・このリポジトリをクローンかダウンロードします。  
・ダウンロードした場合ColorPickerWPFフォルダがありませんので、忘れずにそちらもダウンロードして入れてください  
※以下、UnityはUnity 2019.4.8f1で開いてください。  
※以下のプラグインインポート前に、ProjectSettingsフォルダをコピーしてバックアップしてください！  
※API UpdaterはNo, Thanksで問題ありません。  
・Assets直下にExternalPluginsフォルダを作って、その下に  
　・OVRTracking (OVRTrackingライブラリ - 入れてあります)  
　・UnityMemoryMappedFile (共有メモリライブラリ - 入れてあります)  
　・VMC_Camera (仮想カメラライブラリ - 入れてあります)  
　・DVRSDK ([DVRSDK v1.10.0](https://github.com/dmm-com/vrlab-dvrsdk) - 入れてあります)  
　・RootMotion(Plugins/RootMotionフォルダ) ([Final IK 2.1](https://assetstore.unity.com/packages/tools/animation/final-ik-14290))  
　・SteamVR ([SteamVR.Plugin.unitypackage](https://github.com/ValveSoftware/steamvr_unity_plugin/releases/tag/2.6.1))  
　・VRM ([UniVRM-0.62.0_0b7f.unitypackage](https://github.com/vrm-c/UniVRM/releases))  
　・MeshUtility (UniVRM)  
　・VRMShaders (UniVRM)  
　・Oculus ([Oculus Lipsync Unity Integration v29](https://developer.oculus.com/downloads/package/oculus-lipsync-unity/29.0.0/))  
　・uOSC([uOSC-v0.0.2.unitypackage](https://github.com/hecomi/uOSC/releases/tag/v0.0.2))  
　・MidiJack([MidiJack.unitypackage](https://github.com/keijiro/MidiJack))  
　・EasyDeviceDiscoveryProtocolForUnity([EasyDeviceDiscoveryProtocolForUnity_v002.unitypackage](https://github.com/gpsnmeajp/EasyDeviceDiscoveryProtocolForUnity/releases/tag/v0.02))  
　・mocopi Receiver Plugin for Unity([mocopi-receiver-plugin-for-unity_1.0.1beta.unitypackage](https://sony.net/mocopi-dev))  
以上のようなフォルダになるように各アセットをインポートしてください。  
アイトラッキングが不要な場合Assets\Scripts\EyeTrackingフォルダとLipTrackingフォルダを削除します  
アイトラッキング対応する場合は  
　・ViveSR([Vive-SRanipal-Unity-Plugin.unitypackage](https://developer.vive.com/resources/vive-sense/eye-and-facial-tracking-sdk/download/latest/)) SDK-v1.3.6.6.zip内  
　・Tobii([tobii-unity-sdk-4.0.6.unitypackage](https://developer.tobii.com/pc-gaming/unity-sdk/getting-started/)) tobii/developer zoneからインポート(インポートしたままフォルダは移動しないでください)  
以上の二つをインポート  
※face2vmcなどを使って外部からのモーションを受信する場合にアイトラッキング対応をすると、モーションが競合して目のアニメーションが正常に動作しない場合があります。外部からのモーション受信をする場合はアイトラッキング対応をしないことを推奨します。

※インポートが終わったらUnityをいったん終了し、ProjectSettingsフォルダを削除して、バックアップしておいたProjectSettingsフォルダを戻してください！ 

・ControlWindowWPF/ControlWindowWPF.slnをVisual Studio 2019で開きます。  
・VirtualMotionCaptureControlPanelプロジェクトのプロパティを開きデバッグのコマンドライン引数を/pipeName VMCTestにする。  
・そのままVisualStudioで1回開始します。自動でexeが作成されます。開いたコントロールパネルは閉じて1回終了します。  
・Unityをもう一度起動します  
・UnityのConsoleを見てエラーが出ている個所4か所(ダブルクリックで開く)を  
　UnityEngine.VR.VRDeviceをUnityEngine.XR.XRDeviceに  
　UnityEngine.VR.VRSettingsをUnityEngine.XR.XRSettingsに変更して保存  
・まだエラーが残ってる場合はUnity再起動  
・ScenesフォルダのVirtualMotionCaptureシーンを開いてUnity側の実行  
・VisualStudioでコントロールパネルを開始  
  
**exeのビルド手順**  
・上記通常のデバッグ手順を完了する  
・UnityのBuild SettingでBuildをUnityBuildフォルダに対して実行  
・ControlWindowWPFでBETA構成のビルドを行います  
・ControlWindowWPF/ControlWindowWPF/bin/BETAに全て生成されます  
  
# FAQ  
Q.アプリを使うのに表記はいりますか？  
A.特にいりませんが、あると嬉しいです。その場合は[Twitter](https://twitter.com/sh_akira)をお願いします。  
  ソースコードを使用する場合はMITライセンスです。  
  
Q.Oculus Homeからゲームを起動しようとすると、SteamVRを閉じてしまう  
A.Homeは使用せずにゲームのインストールフォルダから直接exeを実行で回避できる報告がありました  
  
Q.externalcamera.cfgはどうやって設定するの？  
A.みゅみゅさんの記事[【HTC Vive】コントローラ２本でクロマキー合成をする方法](https://qiita.com/miyumiyu/items/25deb3542e913750f519)を参照してください。  
バーチャルモーションキャプチャーのカメラ標準はfov=60です。  
実際にコントローラーを3つ繋いでいる場合は、3本目のコントローラーをカメラ代わりにすることができます。  
  
Q.externalcamera.cfgの位置がおかしい  
A.コントローラー番号を変更して再度ファイルを開いてみてください。  
  
Q.起動後に操作するとフリーズする  
A.VirtualMotionCaputre.exeと同じフォルダにあるdefault.jsonを別のフォルダに移動し、起動後に設定の読込ボタンからdefault.jsonを開くようにすると回避できる場合があります  

Q.ここに書いていないことで困っています  
A.[よくある質問と回答](https://github.com/sh-akira/VirtualMotionCapture/wiki/%E3%82%88%E3%81%8F%E3%81%82%E3%82%8B%E8%B3%AA%E5%95%8F%E3%81%A8%E5%9B%9E%E7%AD%94) も併せて確認してみてください。
  
Q.支援先を教えてください  
A.[欲しいものリスト](https://t.co/KPJRzn6sVR) ギフト送付先(akira.satoh.sh[アットマーク]gmail.com)  
A.[BOOTH](https://sh-akira.booth.pm/items/999760)  
A.[pixivFANBOX](https://www.pixiv.net/fanbox/creator/10267568)  
A.[Patreon](https://www.patreon.com/sh_akira)  
