import java.util.*;

public class a {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc1 = new Scanner(System.in);
		int k = sc1.nextInt();
		String listofnums = "" + k + ",";
		while (true) {
			k = sc1.nextInt();
			if (k == -1) {
				break;
			}
			listofnums += k;
			listofnums += ",";
		}
		listofnums = listofnums.substring(0, listofnums.length() - 1);
		String[] temp = listofnums.split(",");
		int newlength = temp.length;
		int[] newarr = new int[newlength];
		for (int j = 0; j < newlength; j++) {
			int tempnum = Integer.parseInt(temp[j]);
			newarr[j] = tempnum;
		}
		System.out.print(Arrays.toString(newarr));
		int[] uniqueArray = new int[]{};
		int[] counts = new int[]{};
		for (int i = 0; i < newarr.length; i++) {
			int val = newarr[i];
			if (!arrayContains(uniqueArray, val)){
				uniqueArray = addTo(uniqueArray, val);
				counts = addTo(counts, 1);
			}
			else {
				int index = findFirstIndex(uniqueArray, val);
				counts[index] = counts[index]+ 1;
			}
		}
	}

	public static boolean arrayContains(int[] array, int n) {
		for (int i : array) {
			if (i == n)
				return true;
		}
		return false;
	}

	// returns the first index where n occurs in the array
	public static int findFirstIndex(int[] array, int n) {
		for (int i = 0; i < array.length; i++) {
			if (array[i] == n){
				return i;
			}
		}
		return -1;
	}

	public static int[] addTo(int[] array, int n) {
		int[] a = new int[array.length + 1];
		for (int i = 0; i < array.length; i++) {
			a[i] = array[i];
		}
		a[array.length] = n;
		return a;
	}

}