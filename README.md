# Motion-Align (ALIGN_TEST)

RealSense 카메라 영상에서 YOLO 인스턴스 세그멘테이션으로 대상물의 위치·각도를 검출하고, 기준 위치와의 편차만큼 X·Y·θ 3축 모션 스테이지를 보정 이동시키는 비전 얼라인 테스트 프로그램입니다(C# WinForms).

## 동작 흐름

1. **카메라 연결**: 시작 시 RealSense 장치 목록을 조회해 최대 2대를 시리얼 번호로 연결
2. **촬영(One Shot)**: `GrabOnce()` — 5초 타임아웃으로 컬러+깊이 프레임 1장 획득 후 2D 뷰어에 표시
3. **검사(Inspection)**: `Inspect()` — ONNX 세그멘테이션 모델로 윤곽을 구해 위치(TX, TY)와 각도(RX) 산출, 기준점(`BasePoint`)과의 차이를 화면에 표시
4. **이동(Move)**: `Servo_On()` → `Servo_Move()` — 검출값을 펄스로 환산해 X(0)·Y(1)·T(2) 축을 인크리멘탈 이동
   - XY: 1 pulse당 0.42 px, T: 1 pulse당 0.072°, Y축은 방향 반전

## 화면

| 폼 | 기능 |
|---|---|
| `Main_Form` | 카메라 뷰, 기준값·검사값·편차(X, Y, Angle) 표시, 촬영/검사/이동 버튼 |
| `Motion_Form` | 축 선택(Axis00~03), 지령/피드백 위치·속도 모니터, 다축 위치 이동, Jog(+/-), Stop, 알람 리셋 |

## 프로젝트 구조

```
ALIGN_TEST.sln
ALIGN_TEST/
  Main_Form.cs     카메라 연결·촬영·세그멘테이션 검사·보정 이동
  Motion_Form.cs   서보 On, 다축 이동, Jog, 상태 모니터링
  mc2xxstd.cs      SSCNET 모션 컨트롤러 API P/Invoke 래퍼 (mc2xxstd_x64.dll, SscApi)
```

## 개발 환경

- Windows, Visual Studio, .NET Framework 4.8 (WinForms + WPF ElementHost 뷰어)
- NuGet: `Seojin.RobotVision` 1.0.2 (RealSensor, InstanceSegmentation, Viewer_2D 제공)
- 하드웨어: Intel RealSense 카메라, SSCNET 모션 보드 + 서보 3축(X, Y, θ)
- 런타임: 실행 폴더에 `mc2xxstd_x64.dll` 필요 (x64 빌드)

## 설정 시 주의

- 세그멘테이션 모델 경로가 코드에 고정되어 있습니다: `Main_Form.SegmentInitialize()`의 `D:\SEGMENT\...\best.onnx`를 환경에 맞게 수정하세요.
- 기준점 `BasePoint`(TX 400, TY 200, RX 0)는 테스트 값입니다.

## 미구현 / 알려진 제한

- `Align()` 메서드와 이미지 파일 불러오기(`button_ImgLoad_Click`)는 비어 있습니다.
- `Motion_Form`의 `.mot` 설정 파일 불러오기는 파일 선택만 하고 적용하지 않습니다.
- 픽셀↔펄스 환산 계수가 코드 상수로 고정되어 있어 장비 변경 시 재보정이 필요합니다.
