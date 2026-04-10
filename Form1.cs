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
                // 1. 리스트박스와 합계 금액 초기화 (버튼 누를 때마다 새로 계산)
                lstOrder.Items.Clear();
                int totalCost = 0;

                // 2. 버거 선택 확인 (RadioButton - 그룹 중 하나만 선택됨)
                if (rdoHamBurger.Checked)
                {
                    totalCost += 5000;
                    lstOrder.Items.Add("햄버거 - 5,000원");
                }
                else if (rdoBulgogiBurger.Checked)
                {
                    totalCost += 5500;
                    lstOrder.Items.Add("불고기버거 - 5,500원");
                }
                else if (rdoChickenBurger.Checked)
                {
                    totalCost += 6000;
                    lstOrder.Items.Add("치킨버거 - 6,000원");
                }

                // 3. 추가 옵션 확인 (CheckBox - 여러 개 중복 선택 가능)
                if (chkPotato.Checked)
                {
                    totalCost += 3500;
                    lstOrder.Items.Add("사이드: 감자튀김 - 3,500원");
                }
                if (chkCola.Checked)
                {
                    totalCost += 2000;
                    lstOrder.Items.Add("사이드: 콜라 - 2,000원");
                }
                if (chkCheese.Checked)
                {
                    totalCost += 500;
                    lstOrder.Items.Add("추가: 치즈 - 500원");
                }
                if (chkSauce.Checked)
                {
                    totalCost += 500;
                    lstOrder.Items.Add("추가: 소스 - 500원");
                }

                // 4. 최종 금액을 라벨에 출력
                // ToString("N0")는 세 자리마다 쉼표(,)를 찍어주는 서식이야!
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
