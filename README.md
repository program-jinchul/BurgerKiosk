# (C# 코딩) 버거 키오스크

## 개요
- **C# 프로그래밍 학습**: Windows Forms 컨트롤 활용 및 이벤트 기반 프로그래밍 기초 습득
- **1줄 소개**: 사용자가 버거와 옵션을 선택하면 주문 내역을 리스트화하고 총 금액을 계산하는 키오스크 프로그램
- **사용한 플랫폼**: C#, .NET Windows Forms, Visual Studio, GitHub
- **사용한 컨트롤**: Label, RadioButton, CheckBox, ListBox, Button
- **사용한 기술과 구현한 기능**:
    - `RadioButton`과 `CheckBox`를 이용한 메뉴 선택 로직 구현
    - `ListBox`의 `Items` 속성을 이용한 주문 내역 관리
    - `if` 조건문을 활용한 금액 합산 및 예외 처리
    - `Visible` 속성 제어를 통한 동적 UI 피드백

## [과제 1] 버거 키오스크 기본 기능 구현

### 실행 화면
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-1.png)
<img width="1525" height="846" alt="스크린샷 2026-04-09 122031" src="https://github.com/user-attachments/assets/05d4e550-54e7-4e57-9c67-5c30dc4fdf7b" />



### 구현한 내용 (위 그림 참조)
- **UI 구성**: Label(앱 이름), RadioButton(버거 메뉴), CheckBox(사이드 및 추가 옵션), ListBox(주문 내역), Button(주문/초기화)
- **메뉴 선택**: RadioButton을 그룹화하여 메인 버거 1종만 선택 가능하도록 구현
- **주문 계산**: 선택된 항목의 단가를 합산하여 총 금액을 실시간으로 갱신하고 ListBox에 내역 출력
- **초기화**: 초기화 버튼 클릭 시 모든 선택 상태를 해제하고 리스트와 금액을 리셋

## [과제 2] 에러 메시지 화면 표시 구현



### 실행 화면
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-2.png)
<img width="1477" height="715" alt="스크린샷 2026-04-09 131312" src="https://github.com/user-attachments/assets/65806ac8-ce81-4013-b87d-46eaa8f13b8d" />

### 구현한 내용 (위 그림 참조)
- **예외 처리**: 메뉴를 하나도 선택하지 않은 상태에서 '주문하기' 클릭 시 예외 상황 발생
- **화면 표시**: MessageBox를 사용하는 대신, 화면 하단에 `lblMessage` 라벨을 배치하여 경고 문구 출력
- **가시성 제어**: 
    - 평소에는 `lblMessage.Visible = false` 상태로 숨김 처리
    - 예외 발생 시에만 `Visible = true`로 전환하여 사용자에게 알림 제공
- **연동 초기화**: 정상 주문이 이루어지거나 '초기화' 버튼을 누르면 떠 있던 에러 메시지가 다시 사라지도록 구현

## [과제 3] UX 개선 (Enter키 연동 및 포커스 정리)

### 실행 화면
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-3.png)
<img width="1516" height="819" alt="스크린샷 2026-04-09 131342" src="https://github.com/user-attachments/assets/69772c89-f5ea-43bb-bf10-3d9a94129683" />


### 구현한 내용 (위 그림 참조)
- **Enter 키 연동**: 폼의 `AcceptButton` 속성을 '주문하기' 버튼으로 설정하여 키보드만으로 빠른 주문이 가능하도록 개선
- **포커스 흐름 제어**: 
    - 프로그램 실행 시 및 초기화 시 첫 번째 메뉴(`rdoHamBurger`)에 자동으로 포커스가 가도록 `Focus()` 메서드 활용
    - `TabIndex`를 재설정하여 Tab 키 이용 시 논리적인 흐름(메뉴 -> 옵션 -> 버튼)으로 커서가 이동하도록 구현
- **접근성 향상**: 마우스 없이 키보드만으로 전체 주문 과정을 완료할 수 있는 환경 구축

# [과제 4] 보안 및 확인 기능
- **내용**: 미선택 3회 시 프로그램 종료 및 주문 전 `MessageBox` 확인 절차 추가
![실행화면](img/screenshot-4.png)
<img width="1543" height="856" alt="스크린샷 2026-04-09 113159" src="https://github.com/user-attachments/assets/349c8b15-7130-4beb-8a6e-d67c699de715" />



### 구현한 내용 (과제 4 기준)
1. **실패 제한**: `failCount` 변수를 활용해 3회 연속 미선택 주문 시 `Application.Exit()` 호출
2. **최종 확인**: `DialogResult`를 사용하여 사용자가 '예'를 누를 때만 주문 처리
