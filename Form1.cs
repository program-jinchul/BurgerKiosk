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

                // 1. 메뉴 체크
                if (rdoHamBurger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 - 5,000원"); }
                else if (rdoBulgogiBurger.Checked) { totalCost += 5500; lstOrder.Items.Add("불고기버거 - 5,500원"); }
                else if (rdoChickenBurger.Checked) { totalCost += 6000; lstOrder.Items.Add("치킨버거 - 6,000원"); }

                if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("사이드: 감자튀김 - 3,500원"); }
                if (chkCola.Checked) { totalCost += 2000; lstOrder.Items.Add("사이드: 콜라 - 2,000원"); }
                if (chkCheese.Checked) { totalCost += 500; lstOrder.Items.Add("추가: 치즈 - 500원"); }
                if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("추가: 소스 - 500원"); }

               
                // 주문 금액이 0원인지 확인
                if (totalCost == 0)
                {
                    lblMessage.Text = "⚠️ 메뉴를 먼저 선택해 주세요!";
                    lblMessage.ForeColor = System.Drawing.Color.Red; 
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
            InitKiosk();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitKiosk();
        }

        // 공통 초기화 함수
        private void InitKiosk()
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
            lblMessage.Visible = false;

            this.ActiveControl = btnOrder;
        }

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 엔터 키가 눌렸을 때
            if (keyData == Keys.Enter)
            {
                // 1. 현재 포커스가 라디오 버튼(버거)에 있을 때
                if (this.ActiveControl is RadioButton rdo)
                {
                    rdo.Checked = true; // 엔터 치면 해당 버거 선택
                    return true; // 엔터가 주문하기로 넘어가지 않게 가로챔
                }
                // 2. 현재 포커스가 체크박스(사이드)에 있을 때
                else if (this.ActiveControl is CheckBox chk)
                {
                    chk.Checked = !chk.Checked; // 엔터 치면 체크/해제 반복
                    return true; // 엔터가 주문하기로 넘어가지 않게 가로챔
                }
                // 그 외(버튼 등)에 포커스가 있을 때는 원래대로 엔터가 작동함
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItem == null) return;
            string item = lstOrder.SelectedItem.ToString();

            // 리스트에서 클릭한 메뉴로 커서를 보내서 바로 수정할 수 있게 함
            if (item.Contains("햄버거")) rdoHamBurger.Focus();
            else if (item.Contains("불고기버거")) rdoBulgogiBurger.Focus();
            else if (item.Contains("치킨버거")) rdoChickenBurger.Focus();
            else if (item.Contains("감자튀김")) chkPotato.Focus();
            else if (item.Contains("콜라")) chkCola.Focus();
            else if (item.Contains("치즈")) chkCheese.Focus();
            else if (item.Contains("소스")) chkSauce.Focus();
        }

        private void lstOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 선택된 항목이 없으면 중단
            if (lstOrder.SelectedItem == null) return;

            string selectedItem = lstOrder.SelectedItem.ToString();

            // 선택한 텍스트에 포함된 단어에 따라 포커스(Focus)를 이동시킴
            if (selectedItem.Contains("햄버거")) rdoHamBurger.Focus();
            else if (selectedItem.Contains("불고기버거")) rdoBulgogiBurger.Focus();
            else if (selectedItem.Contains("치킨버거")) rdoChickenBurger.Focus();
            else if (selectedItem.Contains("감자튀김")) chkPotato.Focus();
            else if (selectedItem.Contains("콜라")) chkCola.Focus();
            else if (selectedItem.Contains("치즈")) chkCheese.Focus();
            else if (selectedItem.Contains("소스")) chkSauce.Focus();
        }
    }
}
