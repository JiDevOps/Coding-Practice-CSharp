﻿using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    class P1441BuildAnArrayWithStackOperations {
        public static IList<string> BuildArray (int[] target, int n) {
            IList<string> actionList = new List<string>();
            List<int> targetList = target.ToList();

            // if i exists, action is push
            // if i does not exist, action is push and pop
            int count = 1;
            while (targetList.Count > 0 && count <= n) {
                if (targetList.Contains(count)) {
                    actionList.Add("Push");
                    targetList.Remove(count);
                } else {
                    actionList.Add("Push");
                    actionList.Add("Pop");
                }

                count++;
            }

            return actionList;
        }
    }
}
