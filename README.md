# T9

I stumbled upon [this article](https://itnext.io/a-more-declarative-solution-to-the-t9-problem-in-both-javascript-and-c-13ab7f7a859b) article today and really liked the concept. I thought that author's c# solution, however, was a bit lacking. If you're going declarative, why not going all the way?

Rather than projecting to a matrix and awkwardly building a list in a pseudo-imperative style, I figured we could take advantage of a seeded `Aggregate` and a `SelectMany` to accomplish the goal 100% declaratively.

If it looks like greek, the imperative equivelent is:
1. Take the first digit and create a list of its letters
2. On each subsequent digit, take the current list. For each partial string in the list, create a new list with each digit combination appended to the partial string
