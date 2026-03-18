## Answers

### 1. When does Git perform a fast-forward, and when is a merge commit created?
Git performs a fast-forward merge when the target branch has no new commits since the feature branch was created, so the branch pointer can simply move forward. A merge commit is created when both branches contain their own new commits and Git has to combine two separate lines of history. In my repository, this merge was not fast-forward because `feature-max` contained the `CalculateMax` method, while `main` had an additional independent commit. :contentReference[oaicite:1]{index=1}

### 2. What is the practical difference between merge and rebase?
A merge keeps the original branch structure and usually creates a separate merge commit, so the history clearly shows where development split and where it was combined again. A rebase rewrites the branch commits so they appear on top of the current `main`, which makes the history cleaner and more linear. In practice, merge preserves the exact development history, while rebase makes it easier to read. :contentReference[oaicite:2]{index=2}

### 3. How was the conflict resolved in your repository?
The conflict was resolved consciously by editing the conflicting code manually instead of randomly choosing one version. Both branches changed the same validation message, so after the conflict appeared, I removed the conflict markers and replaced the two competing lines with one final message that combined the meaning of both changes: `Błąd: wpisz poprawny wiek (liczba całkowita).` This way, the code still worked correctly after the conflict was resolved. :contentReference[oaicite:3]{index=3}