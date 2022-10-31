# 2022_GameSoftware
2022_GameSoftware

소프트웨어학과 20195298 박준용


실행환경
- Unity : 2021.3.9f1


[SampleScene] - 5점 (구현완료)
1. 3D Object Shpere 추가하고 해당 Shpere에 Prefab 활용하여 다양한 모습(차, 비행기 등)으로 변경 
    Asset Store에서 Shpere에 반영할 Asset을 import 하고 import한 prefab을 Shpere에 적용 (2점)   
(구현완료)
2. 변수로 Cube 오브젝트를 제어하는 것으로 Cube와 Plane(바닥)을 생성하고 Cube에 Rigidbody 컴포넌트를 추가
    속성창에서 Rigidbody 컴포넌트의 Use Gravity는 체크하지 않고 Gravity는 false 로 설정
    Cube 스크립트에서 Rigidbody 컴포넌트 선언하고 
    Rigidbody의 method를 활용하여 false로 초기화된 Gravity를 true로 변경
    Cube는 Plane(바닥) 보다는 위쪽에 위치하도록 Y축 값으로 설정 실행 버튼을 클릭하여 게임창에서 Cube가 중력을 받고 내려가서 Plane(바닥)에 떨어지는지 확인 (3점)  
    (구현완료)

[ParticleScene] - 5점
1. Particle System을 추가하고 속성값 5개 이상 변경하여 반영 (5점)
    변경된 속성값은 Readme.txt 파일에 설명을 작성

FX_Fire
- Start Lifetime 변경 (2)
- Start Speed 변경 (1)
- Emission -> Rate over Time 변경 (40)
- Shpae -> Angle 수정 (0)
- Color 수정
- Size over Lifetime (크기 변경)
- Noise -> Strength 변경 (0.4)

FX_Smoke
- Start Lifetime 변경 (6)
- Start Speed 변경 (2)
- Shpae -> Angle 수정 (25)
- Color 수정
- Size over Lifetime (크기 변경)
- Rotation over Lifetime 변경(-45, 45)

[TerrainScene] - 5점 (구현완료)
1. 3D Object로 Terrain을 추가하고 표면(Layer) Texture 변경, Brush로 산, 언덕 만들고
    나무, 잔디, Wind zone 추가 (5점)
    

[BackgroundScene] - 5점
1. 스크롤되는 배경화면 만들기 (5점)
    * 배경화면(Space Star Field Backgrounds)과 오브젝트(Awesome Cartoon Airplanes)는 
       수업시간에 하지 않은 Asset으로 반영
    * Asset으로 Space Star Field Backgrounds, Awesome Cartoon Airplanes을 사용하는 경우와
       다른 학생과 동일한 Asset에 동일한 속성값 사용시 감점