// CDlgTest.cpp: 구현 파일
//

#include "pch.h"
#include "MFCApplication.h"
#include "CDlgTest.h"
#include "afxdialogex.h"


// CDlgTest 대화 상자

IMPLEMENT_DYNAMIC(CDlgTest, CDialogEx)

CDlgTest::CDlgTest(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_CDlgTest, pParent)
{

}

CDlgTest::~CDlgTest()
{
}

void CDlgTest::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CDlgTest, CDialogEx)
	ON_BN_CLICKED(IDC_BUTTON1, &CDlgTest::OnBnClickedTestButton)
	ON_BN_CLICKED(IDC_BUTTON2, &CDlgTest::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BTN_OK, &CDlgTest::OnBnClickedBtnOk)
	ON_BN_CLICKED(IDC_BTN_CANCEL, &CDlgTest::OnBnClickedBtnCancel)
	ON_BN_CLICKED(IDC_BTN_SAVE, &CDlgTest::OnBnClickedBtnSave)
END_MESSAGE_MAP()


// CDlgTest 메시지 처리기

int btnstatus = 1;
void CDlgTest::OnBnClickedTestButton()
{	
	CFont f;
	CButton* btn = (CButton*)GetDlgItem(IDC_BUTTON1);
	if (btnstatus) {
		btn->SetWindowTextW(L"ON");
	}
	else{
		btn->SetWindowTextW(L"OFF");
	}
	++btnstatus %= 2;
}

void CDlgTest::OnBnClickedButton2()
{
	CFileDialog df(TRUE);
	OPENFILENAME& ofn = df.GetOFN();
	ofn.Flags |= OFN_ALLOWMULTISELECT;
	if (df.DoModal() == IDCANCEL) return;
	CString fPath = df.GetPathName(); //full path 전체 경로

	CFile f;
	f.Open(fPath,CFile::modeRead); //LPCTSTR == wchar_t -> WCHAR, 2바이트 문자체계 
	int n = f.GetLength();
	char* buf = new char[n];
	WCHAR* wBuf = new WCHAR[n];
	//char = a,b,c,d
	//Wchar = a0,b0,c0,d0

	f.Read(buf, n); //f의 파일을 n바이트 만큼 buf에 읽음.
	f.Close();
	MultiByteToWideChar(CP_ACP, 0, buf, n, wBuf, 0);
	GetDlgItem(IDC_EDIT1)->SetWindowTextW(wBuf);
	
	delete wBuf;
	delete buf;
}

void CDlgTest::OnBnClickedBtnOk()
{
	EndDialog(IDOK);
}

void CDlgTest::OnBnClickedBtnCancel()
{
	EndDialog(IDCANCEL);
}

void CDlgTest::OnBnClickedBtnSave()
{

}
//{	
//	CString buf;
//	GetDlgItem(IDC_EDIT1)->GetWindowText(buf);
//	CFileDialog fd(FALSE);
//
//	if (fd.DoModal() == IDOK){
//		char *fpath = new char[fd.GetPathName().GetLength()+1];
//		WideCharToMultiByte(CP_ACP, 0, fd.GetPathName(), -1, fpath, fd.GetPathName().GetLength() + 1, NULL, NULL);
//		FILE* fp = fopen(fpath, "wt");
//		if (fp == NULL)
//		{
//			AfxMessageBox(L"Do not Create File");
//			return;
//		}
//		fwrite(buf, buf.GetLength(), 1, fp);
//		fclose(fp);
//	}
//	delete fd;
//}
