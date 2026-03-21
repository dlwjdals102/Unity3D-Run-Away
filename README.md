Unity 3D로 만든 포트폴리오용 프로젝트입니다.

## 프로젝트 개요

프로젝트 명: Run Away<br><br>
장르 : 3D Top-down 액션<br><br>
개발 기간: 2026.03.12 ~ 2026.03.19<br><br>
개발 인원: 1인개발<br><br>
개발 스택: Unity 6.3 LTS (6000.3.9f1), C#<br><br>

흔들리는 다리 위에서 끝없이 날아오는 장애물들을 피하며 주어진 시간안에 가장 많은 점수를 획득하는 게임입니다.

## 플레이 영상

https://github.com/user-attachments/assets/ea159906-6898-4f0a-b0f8-11ddfa1723ed

## 핵심 구현요소

### ⭕ 절차적 레벨 생성
  * 청크 기반 맵 생성
    * 일정 길이의 청크를 순차적으로 생성하여 무한 맵 구성
    * 플레이어 위치 기준으로 필요한 구간만 동적으로 생성
  * 콘텐츠 자동 생성
    * 청크 내부에서 장애물, 아이템을 개별 함수로 분리하여 생성
  * 확률 기반 스폰 시스템
    * 스폰 포인트에서 Random.value를 활용하여 생성 여부 결정
    * 데이터 기반으로 다양한 오브젝트 확장 가능
  * 적응형 난이도 조절
    * 플레이 시간 증가에 따라 장애물 생성 확률 상승
    * 자연스럽게 난이도가 증가하도록 설계
<br>

### ⭕ 플레이어 컨트롤
  * 입력 기반 이동 처리
    * 좌우 이동 입력 구현
    * Time.deltaTime 기반 프레임 독립적 이동 처리
  * 물리 기반 캐릭터 제어
    * 자연스러운 이동을 위한 물리값 조정
  * 충돌 및 상호작용 처리
    * 장애물 충돌 시 속도 제어 및 카메라 워크
    * 아이템 획득 시 점수 및 상태 변화 적용
<br>

### ⭕ Post processing 기반 비주얼 개선

<p align="center">
  <img height="250" src="https://github.com/user-attachments/assets/4c8f68ea-92e5-465c-b206-a9bb9b3a45c8" />
  <img height="250" src="https://github.com/user-attachments/assets/4de0e217-7dd0-44d0-9ed5-862a807634d5" />
</p>
<br>

  * Color Grading
    * 전체 색감을 보정하여 선명하고 생동감 있는 화면 연출
  * Tonemapping
    * 밝기 범위를 조정하여 과도한 명암을 완화하고 자연스러운 화면 표현 구현
  * Bloom
    * 밝은 영역에 빛 번짐 효과를 추가하여 시각적 강조 및 속도감 강화
  * Vignette
    * 화면 외곽을 어둡게 처리하여 플레이어 시선 중앙 집중 유도
  * Depth of Field
    * 플레이어에 초점을 맞추고 배경을 흐리게 처리하여 공간감과 몰입감 향상
<br>

### ⭕ UX

<p align="center">
  <img width="802" height="455" alt="Image" src="https://github.com/user-attachments/assets/1517f597-6211-45b2-9ea0-687aa9764a5c" />
</p>
  
  * Cinemachine 카메라 제어
    * 플레이어를 중심으로 자연스럽게 추적하는 카메라 구성
    * 상황에 따라 카메라 움직임을 조정하여 안정적인 시야 제공
  * Particle
    * 충돌, 아이템 획득 등의 이벤트에 Particle 효과 적용
    * 플레이어 행동에 대한 즉각적인 시각 피드백 제공


