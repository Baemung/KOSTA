// CTestDLG.cpp: 구현 파일
//
#include "pch.h"
#include "MFCApplication.h"
#include "CTestDLG.h"
#include "afxdialogex.h"


// CTestDLG 대화 상자

IMPLEMENT_DYNAMIC(CTestDLG, CDialogEx)

CTestDLG::CTestDLG(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DLG_Test, pParent)
{

}

CTestDLG::~CTestDLG()
{
}

void CTestDLG::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_STATIC_Text1, cStaticTest);
}


BEGIN_MESSAGE_MAP(CTestDLG, CDialogEx)
	ON_COMMAND(IDD_DLG_Test, &CTestDLG::OnIddDlgTest)
	ON_BN_CLICKED(IDC_BTN_Test, &CTestDLG::OnClickedBtnTest)
END_MESSAGE_MAP()


// CTestDLG 메시지 처리기

void CTestDLG::OnIddDlgTest()
{

}


BOOL CTestDLG::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// TODO:  여기에 추가 초기화 작업을 추가합니다.

	CFont f;
	f.CreateFont(36,0,0,0,0,0,0,0,0,0,0,0,0,TEXT("Arial"));
	/*GetDlgItem(IDC_STATIC_Text1)->SetWindowTextW(L"안녕하세요.");
	GetDlgItem(IDC_STATIC_Text1)->SetFont(&f);*/
	cStaticTest.SetFont(&f);
	cStaticTest.SetWindowTextW(L"안녕하세요.");
	return TRUE;  // return TRUE unless you set the focus to a control
				  // 예외: OCX 속성 페이지는 FALSE를 반환해야 합니다.
}


void CTestDLG::OnClickedBtnTest()
{	
	//CEdit e;0
	CString buf, lenBuf;
	GetDlgItem(IDC_EDIT2)->GetWindowText(buf);
	GetDlgItem(IDC_EDIT3)->SetWindowText(buf.MakeUpper());
	lenBuf.Format(_T("%d"), buf.GetLength());
	GetDlgItem(IDC_EDIT4)->SetWindowText(lenBuf);
}
