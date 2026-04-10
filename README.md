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

---

## [과제 1] 버거 키오스크 기본 기능 구현

## 실행 화면
![과제1 실행화면]
<img width="1866" height="838" alt="스크린샷 2026-04-10 201635" src="https://github.com/user-attachments/assets/7f3f6808-6eef-44a4-a285-ce68b6740fbd" />


## 구현한 내용
- **UI 구성**: Label, RadioButton(버거), CheckBox(옵션), ListBox, Button 배치
- **메뉴 선택**: GroupBox를 활용해 라디오 버튼 중 메인 버거 1종만 선택되도록 제한
- **주문 계산**: 각 메뉴의 단가를 변수에 할당하여 총 금액을 합산하고 결과를 라벨에 출력
- **초기화**: 초기화 버튼 클릭 시 모든 컨트롤의 상태를 초기값으로 리셋

---

## [과제 2] 에러 메시지 화면 표시 구현

## 실행 화면
![과제2 실행화면]
<img width="1576" height="835" alt="스크린샷 2026-04-10 201714" src="https://github.com/user-attachments/assets/543b8b1f-30a5-45e6-8976-a86a29e2c1e9" />


## 구현한 내용
- **예외 처리**: 메뉴를 하나도 선택하지 않고 '주문하기' 클릭 시 주문 차단 로직 구현
- **화면 표시**: 메시지 박스 대신 화면 내 `lblMessage` 라벨을 통해 경고 문구 출력
- **가시성 제어**: `Visible` 속성을 사용하여 평소에는 숨기고 에러 발생 시에만 빨간색 경고 표시
- **연동 초기화**: 정상 주문 진행 혹은 초기화 버튼 클릭 시 경고 메시지가 자동으로 사라지도록 처리

---

## [과제 3] UX 개선 (Enter키 연동 및 포커스 정리)

## 실행 화면
![과제3 실행화면]
<img width="1635" height="828" alt="스크린샷 2026-04-10 201957" src="https://github.com/user-attachments/assets/92a23c5a-cfef-4588-b1f2-eeb5919edd0d" />
https://github.com/user-attachments/assets/bc420da6-a02c-4e30-b33f-a143edcad2d3




## 구현한 내용
- **Enter 키 연동**: `ProcessCmdKey` 및 키보드 이벤트 가로채기를 통해 마우스 없이 메뉴 선택 가능 환경 구축
- **포커스 흐름 제어**: 
    - 햄버거 자동 선택 방지를 위해 시작 시 포커스를 '주문하기' 버튼으로 강제 이동
    - `TabIndex`를 최적화하여 Tab 키 사용 시 메뉴 순서대로 커서가 이동하도록 개선
- **접근성 향상**: 마우스 없이 방향키와 엔터키만으로 전체 메뉴 선택 및 주문 과정 완료

---

## [과제 4] 보안 및 확인 기능

## 실행 화면
![과제4 실행화면]
<img width="1805" height="837" alt="스크린샷 2026-04-10 202007" src="https://github.com/user-attachments/assets/e625656e-baed-4a19-9fe2-9c4a83bf4f16" />


## 구현한 내용
- **실패 제한**: `failCount` 변수를 도입해 3회 연속 미선택 주문 시 프로그램을 강제 종료하는 보안 기능 추가
- **최종 확인**: 주문 직전 `MessageBox`를 띄워 사용자가 최종적으로 주문을 확정(Yes/No)하도록 구현
- **실시간 업데이트**: `CheckedChanged` 이벤트 연결을 통해 메뉴 선택 시 즉시 리스트박스와 금액이 갱신되는 기능 구현
- **선택 수정 기능**: 리스트박스의 항목 클릭 시 해당 메뉴 컨트롤로 포커스를 이동시켜 즉각적인 수정 지원