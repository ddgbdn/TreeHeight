namespace TreeHeight
{
    public static class HeightCalculator
    {
        // Not configured to work with null: Nullables are enabled
        public static int GetHeight(Branch branch, int h = 1)
        {
            var branchesHeights = new List<int>();

            foreach (var child in branch.Branches)
                branchesHeights.Add(GetHeight(child, h + 1));

            if (branch.Branches.Count == 0)
                return h;

            return branchesHeights.Max();
        }
    }
}
