class Pedigree {
    private Cat? root;

    public Pedigree(){
        root = null;
    }

    /// <summary>
    /// Create a new cat, optionally with a mother cat.
    /// 
    /// Precondition: 
    /// - No cat in the pedigree has the same name as the new cat.
    /// - The new cat's name is valid.
    /// - If the mother cat is not null, the mother cat must exist in the pedigree.
    /// 
    /// Postcondition:
    /// - If the root is null, the new cat is created as the root.
    /// - If the mother cat is not null, the new cat is added as the last child of the mother cat, or the first child if the mother cat has no children.
    /// - If the mother cat is null, the new cat is added as the last cat in the pedigree, by breadth-first search.
    /// - The cat is added to the pedigree.
    /// - The cat's age is set to 0.
    /// 
    /// If the precondition is met, the method returns true.
    /// 
    /// If the precondition is not met, the pedigree is not modified, and the method returns false.
    /// 
    /// </summary>
    /// <param name="catName">The name of the new cat</param>
    /// <param name="motherName">(Optional) the name of the mother cat. Defaults to null.</param>
    /// <returns>true if the new cat was added successfully, false otherwise</returns>
    public bool AddCat(string catName, string? motherName = null){
        // If the root is null, create the new cat as the root

        // If the cat already exists, return false

        // If the mother cat does not exist, make the new cat the last cat in the pedigree by depth-first search

        // Otherwise, find the mother cat

        // If the mother cat exists, check if the new cat's name is valid

        // If the mother cat exists and the new cat's name is valid, create the new cat

        // If the mother cat has no children, make the new cat the first child of the mother cat

        // If the mother cat has children, make the new cat the last child of the mother cat

        throw new NotImplementedException();
    }

    /// <summary>
    /// Find a cat in the pedigree by name through a breadth-first search.
    /// 
    /// Precondition:
    /// - The cat must exist in the pedigree.
    /// 
    /// Postcondition:
    /// - The pedigree is not modified.
    /// 
    /// If the cat is found, the method returns the cat.
    /// 
    /// If the cat is not found, the method returns null.
    /// 
    /// </summary>
    /// <param name="name">The name of the cat to find</param>
    /// <returns>The cat if found, null otherwise</returns>
    public Cat? FindCat(string name){
        // Find a cat using a breath-first search

        // If the cat is found, return the cat

        // If the cat is not found, return null

        throw new NotImplementedException();
    }

    /// <summary>
    /// Convert the pedigree to an array by depth-first search.
    /// 
    /// Precondition: N/A
    /// 
    /// Postcondition:
    /// - The pedigree is not modified.
    /// 
    /// If the pedigree is empty, the method returns an empty array.
    /// 
    /// If the pedigree is not empty, the method returns an array of cats, where the first cat is the root, and the last cat is the last cat in the pedigree by depth-first search.
    /// 
    /// </summary>
    /// <returns>The pedigree as an array</returns>
    public Cat[] ToArray(){

        throw new NotImplementedException();
    }
}