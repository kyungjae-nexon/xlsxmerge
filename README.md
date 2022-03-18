# XlsxMerge

XlsxMerge는 엑셀 문서를 비교하고, 내용을 병합할 수 있는 도구입니다.

- 엑셀 문서의 행(row) 방향 변경점을 비교해 볼 수 있습니다.
- 두 개, 또는 세 개 문서의 병합 (3-way merge) 이 가능합니다.

## 개발 중입니다.
- 초기 단계의 개발 버전을 올려놓았습니다. UI 및 기능은 아직 성숙한 단계가 아닙니다.

## 실행 환경
 - Excel 이 설치된 Windows OS
 - .NET Framework 4.6 이상이 설치되어 있어야 합니다.
 - diff 도구 : 내부 동작으로 Unix Diff 도구를 사용합니다.
 - XlsxMerge 실행 폴더에 diff.exe 와 diff3.exe 도구가 있어야 합니다.
   - https://sourceforge.net/projects/unxutils/files/unxutils/current/

## 미리 알아둘 것

### 사용에 적합한 엑셀 문서
- 머지에 적합한 엑셀 문서의 형식은 다음과 같습니다.
  - 일반적인 표 작업 위주의 문서
  - 주로 행 단위로 변경이 일어나는 문서
  - 이미지, 매크로 등은 머지를 지원하지 않습니다.

### 값과 수식만을 비교합니다
 - 주석, 차트, 도형, VBA 매크로 등은 비교하지 않으며, 머지를 보장하지도 않습니다.

### 머지(병합) 후 체크리스트
 - 결과물은 커밋 전 반드시 직접 확인합니다
   - 도구에서 보이는 것과 다른 점이 있는지, 사이드 이펙트는 없는 지 확인합니다.
 - 수식 재계산이 필요할 수 있습니다.
   - 엑셀 파일에 연결된 외부 문서나 외부 데이터소스 가 있다면, 머지 과정에서 최신 데이터가 반영이 되지 않을 수 있습니다.
   - 이 경우에는 머지 후 수식 전체 재계산을 해 주세요.
   - `Ctrl`+`Shift`+`Alt`+`F9` 단축키를 통해 전체 재계산을 할 수 있습니다.

# 연동하기
XlsxMerge는 svn, git, perforce, plasticscm 등 여러 SCM 에 연동하여 사용이 가능합니다.
* [연동 가이드](./docs/integration.md)

# 크레딧
Product of Nexon Korea

- 주 개발 : Kyungjae Park ( @kyungjae-nexon / @kyungjaepark )
- 기획 및 프로토타입 제작 : Eunseok Yi ( @paparang ), Chanwoong Kim ( @kexplo )
- 로고 제작 : Jungsoo Lee ( @IntBread )
