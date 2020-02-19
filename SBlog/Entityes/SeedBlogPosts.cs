using MVC_Intro.Models;
using System.Linq;

namespace MVC_Intro.Entityes
{
    public class SeedBlogPosts
    {
        public static void SeedBlogData(DBContext context)
        {
            if (!context.Blog.Any())
            {
                context.Blog.AddRange(
                new BlogModel
                {
                    author = "Blizzard",
                    title = "Overwatch PTR Patch Notes – February 13, 2020",
                    preview = "Please note that the below patch notes only include changes currently available for testing on the PTR. While many of these changes may also be available on PlayStation 4 and Xbox One in a future patch, the PTR is PC-only and only reflects changes coming specifically to that platform.",
                    fullPost = "BUG FIXES" +
                    "Workshop" +
                    "Fixed a bug where disabling certain flow control actions(If, Else If, Else, etc.) could lead to incorrect execution and incorrect editor indention" +
                    "Fixed a bug where an Else If block followed by an End would cause a rule to prematurely abort if the Else If condition were false" +
                    "Fixed a bug where the Loop If Condition and Abort If Condition actions considered the value of the conditions from the beginning of the frame instead of their current value" +
                    "Fixed a bug where the Chase Global Variable actions did not have access to contextual values(such as Event Player, Attacker, Victim, etc.)" +
                    "Fixed a bug where modifying a variable after chasing it would give the variable an incorrect value" +
                    "Fixed a bug where modifying a single player variable after setting or modifying it as part of a multi - player variable change would give the variable an incorrect value" +
                    "Fixed a bug where effects and beam effects that don’t reevaluate would wait until the end of the frame to evaluate their positions and radii rather than evaluating them immediately" +
                    "Fixed a bug where the Total Elapsed Time value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value stopped working near the statue in Château Guillard" +
                    "Fixed a bug where using the same Set Facing action multiple times in the same frame with different inputs would not work correctly" +
                    "Fixed an editor crash caused by pasting subroutines into a slot outside of the default range" +
                    "Fixed a bug where subroutines would stop executing upon encountering a disabled action",
                    img = "09509d51-5837-48e6-b4b7-161c2ce8bbb0_overwatch_patch_notes_0-590x334.jpg"
                },
             new BlogModel
             {
                 author = "Blizzard",
                 title = "Overwatch PTR Patch Notes – February 7, 2020",
                 preview = "Please note that the below patch notes only include changes currently available for testing on the PTR. While many of these changes may also be available on PlayStation 4 and Xbox One in a future patch, the PTR is PC-only and only reflects changes coming specifically to that platform.",
                 fullPost = "BUG FIXES" +
                    "Workshop" +
                    "Fixed a bug where disabling certain flow control actions(If, Else If, Else, etc.) could lead to incorrect execution and incorrect editor indention" +
                    "Fixed a bug where an Else If block followed by an End would cause a rule to prematurely abort if the Else If condition were false" +
                    "Fixed a bug where the Loop If Condition and Abort If Condition actions considered the value of the conditions from the beginning of the frame instead of their current value" +
                    "Fixed a bug where the Chase Global Variable actions did not have access to contextual values(such as Event Player, Attacker, Victim, etc.)" +
                    "Fixed a bug where modifying a variable after chasing it would give the variable an incorrect value" +
                    "Fixed a bug where modifying a single player variable after setting or modifying it as part of a multi - player variable change would give the variable an incorrect value" +
                    "Fixed a bug where effects and beam effects that don’t reevaluate would wait until the end of the frame to evaluate their positions and radii rather than evaluating them immediately" +
                    "Fixed a bug where the Total Elapsed Time value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value stopped working near the statue in Château Guillard" +
                    "Fixed a bug where using the same Set Facing action multiple times in the same frame with different inputs would not work correctly" +
                    "Fixed an editor crash caused by pasting subroutines into a slot outside of the default range" +
                    "Fixed a bug where subroutines would stop executing upon encountering a disabled action",
                 img = "66e23524-a96f-462c-a8ec-221c09f35137_144139-ow-patchnote-eichenwalde-article_m-1.jpeg"
             },
             new BlogModel
             {
                 author = "Blizzard",
                 title = "Overwatch PTR Patch Notes – February 4, 2020",
                 preview = "Please note that the below patch notes only include changes currently available for testing on the PTR. While many of these changes may also be available on PlayStation 4 and Xbox One in a future patch, the PTR is PC-only and only reflects changes coming specifically to that platform.",
                 fullPost = "GENERAL UPDATES" +
                    "Workshop" +
                    "Fixed a bug where disabling certain flow control actions(If, Else If, Else, etc.) could lead to incorrect execution and incorrect editor indention" +
                    "Fixed a bug where an Else If block followed by an End would cause a rule to prematurely abort if the Else If condition were false" +
                    "Fixed a bug where the Loop If Condition and Abort If Condition actions considered the value of the conditions from the beginning of the frame instead of their current value" +
                    "Fixed a bug where the Chase Global Variable actions did not have access to contextual values(such as Event Player, Attacker, Victim, etc.)" +
                    "Fixed a bug where modifying a variable after chasing it would give the variable an incorrect value" +
                    "Fixed a bug where modifying a single player variable after setting or modifying it as part of a multi - player variable change would give the variable an incorrect value" +
                    "Fixed a bug where effects and beam effects that don’t reevaluate would wait until the end of the frame to evaluate their positions and radii rather than evaluating them immediately" +
                    "Fixed a bug where the Total Elapsed Time value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value would be incorrect if used in a HUD action or in certain reevaluating actions" +
                    "Fixed a bug where the Nearest Walkable Position value stopped working near the statue in Château Guillard" +
                    "Fixed a bug where using the same Set Facing action multiple times in the same frame with different inputs would not work correctly" +
                    "Fixed an editor crash caused by pasting subroutines into a slot outside of the default range" +
                    "Fixed a bug where subroutines would stop executing upon encountering a disabled action",
                 img = "d6dc92a7-44a2-400f-861e-dbf4d959d556_overwatch-updates.jpg"
             }
            );
            }
            context.SaveChanges();
        }
    }
}
