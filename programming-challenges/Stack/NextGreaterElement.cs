namespace programming_challenges.Stack;

public class NextGreaterElement
{
    public int[] NextGreaterElementSolution(int[] nums1, int[] nums2) {
        // Dicionário que armazena o próximo maior elemento de cada número de nums2
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();
        // Pilha para armazenar os números sem um próximo maior ainda encontrado
        Stack<int> stack = new Stack<int>();
        
        // Percorra nums2 para construir o mapeamento do próximo maior
        foreach (var num in nums2) {
            // Enquanto o número atual for maior que o do topo da pilha
            // isso significa que encontramos o próximo maior para o número no topo da pilha
            while (stack.Count > 0 && stack.Peek() < num) {
                nextGreater[stack.Pop()] = num;
            }
            // Empilha o número atual
            stack.Push(num);
        }
        
        // Para todos os elementos restantes na pilha, não há próximo maior, então mapeamos -1
        while (stack.Count > 0) {
            nextGreater[stack.Pop()] = -1;
        }
        
        // Para cada número em nums1, buscamos o próximo maior no dicionário e construímos o resultado
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            result[i] = nextGreater[nums1[i]];
        }
        
        return result;
    }
}