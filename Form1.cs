namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            {
                // 초기화
                lstOrder.Items.Clear();
                int totalCost = 0;

                // 1. 메뉴 체크 (기존 과제 1 로직)
                if (rdoHamBurger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 - 5,000원"); }
                else if (rdoBulgogiBurger.Checked) { totalCost += 5500; lstOrder.Items.Add("불고기버거 - 5,500원"); }
                else if (rdoChickenBurger.Checked) { totalCost += 6000; lstOrder.Items.Add("치킨버거 - 6,000원"); }

                if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("사이드: 감자튀김 - 3,500원"); }
                if (chkCola.Checked) { totalCost += 2000; lstOrder.Items.Add("사이드: 콜라 - 2,000원"); }
                if (chkCheese.Checked) { totalCost += 500; lstOrder.Items.Add("추가: 치즈 - 500원"); }
                if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("추가: 소스 - 500원"); }

                // [과제 2 추가 포인트] ----------------------------------------------------
                // 주문 금액이 0원인지 확인
                if (totalCost == 0)
                {
                    lblMessage.Text = "⚠️ 메뉴를 먼저 선택해 주세요!";
                    lblMessage.ForeColor = System.Drawing.Color.Red; // 쌈뽕하게 빨간색으로!
                    lblMessage.Visible = true;  // 숨겨져 있던 라벨을 보이게 함
                    return; // 여기서 함수 종료 (아래 합계 출력을 실행하지 않음)
                }
                else
                {
                    lblMessage.Visible = false; // 메뉴가 선택됐다면 경고 메시지를 다시 숨김
                }
                // ----------------------------------------------------------------------

                // 최종 금액 출력
                lblTotal.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
        }
    }
}
