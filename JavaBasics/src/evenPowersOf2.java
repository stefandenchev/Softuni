import java.util.Scanner;

public class evenPowersOf2 {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        int n = Integer.parseInt(s.nextLine());
        int number = 1;

        for (int i = 0; i <= n; i += 2){
            System.out.println(number);
            number = number * 2 * 2;
        }
    }
}