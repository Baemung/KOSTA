﻿// CDrawTest.cpp: 구현 파일
//

#include "pch.h"
#include "MFCApplication.h"
#include "CDrawTest.h"
#include "afxdialogex.h"


// CDrawTest 대화 상자

IMPLEMENT_DYNAMIC(CDrawTest, CDialogEx)

CDrawTest::CDrawTest(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_CDrawTest, pParent)
{

}

CDrawTest::~CDrawTest()
{
}

void CDrawTest::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CDrawTest, CDialogEx)
	ON_WM_LBUTTONDOWN()
END_MESSAGE_MAP()


// CDrawTest 메시지 처리기

CStatic* PD;
CDC* PDC;

BOOL CDrawTest::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// TODO:  여기에 추가 초기화 작업을 추가합니다.
	PD = (CStatic*)GetDlgItem(IDC_PNL_Draw);
	PDC = GetDC(); //Device Context pointer는 문자, 이미지를 출력 또는 이미지를 그릴 수 있게 만드는 클래스

	return TRUE;  // return TRUE unless you set the focus to a control
				  // 예외: OCX 속성 페이지는 FALSE를 반환해야 합니다.
}


void CDrawTest::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	int r = 100; //반지름
	PDC->Ellipse(point.x-r, point.y-r, point.x+r, point.y+r);

	CDialogEx::OnLButtonDown(nFlags, point);
}
