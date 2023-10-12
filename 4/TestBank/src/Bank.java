public class Bank {


    public static void main(String[] args) {

        int baht = 243;

        System.out.println(baht + "Baht" + change(baht));

    }

    //แปลงเงินเป็นจำนวนแบงค์

    public static String change(int baht) {

        final int b500 = 500;
        final int b100 = 100;
        final int b50 = 50;
        final int b20 = 20;
        final int c10 = 10;
        final int c5 = 5;
        final int c2 = 2;
        final int c1 = 1;

        int bank500 = baht / b500;
        baht = baht % b500;

        int bank100 = baht / b100;
        baht = baht % b100;

        int bank50 = baht / b50;
        baht = baht % b50;

        int bank20 = baht / b20;
        baht = baht % b20;

        int coin10 = baht / c10;
        baht = baht % c10;

        int coin5 = baht / c5;
        baht = baht % c5;

        int coin2 = baht / c2;
        baht = baht % c2;

        int coin1 = baht / c1;
        baht = baht % c1;

        return "\nbank500 ="+bank500+"\nbank100 ="+bank100+"\nbank50 =" + bank50+"\nbank20 =" + bank20+"\ncoin10 =" + coin10+"\ncoin5 =" + coin5+"\ncoin2 =" + coin2+"\ncoin1 =" + coin1;
    }
}


        //แปลงเงินกลับ

//        public static String value(int bank50,int bank20,int coin10,int coin1){
//
//            int money;
//
//            int Note50 = 50;
//
//            money = bank50*Note50;
//
//            int Note20 = 20;
//
//            money = (bank20*Note20)+money;
//
//            int Note10 = 10;
//
//            money = (coin10*Note10)+money;
//
//            int Note1 = 1;
//
//            money = (coin1*Note1)+money;
//
//
//
//            return "Value ="+money+"Baht";



//        }


//
//    }
