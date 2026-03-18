This merge was not fast-forward because both branches had new commits.
The `feature-max` branch contained the `CalculateMax` method, while `main`
had an additional independent commit. Git had to create a merge commit
to combine both histories.

After merge, the history contains a separate merge commit and shows a branch split.
After rebase, the history is more linear because the commits from the feature-min branch were moved to the top of main.