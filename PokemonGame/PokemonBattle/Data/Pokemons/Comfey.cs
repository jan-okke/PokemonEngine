using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Comfey : Pokemon
	{
		public override string Name => "Comfey";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flowerveil(), new Abilities.Triage() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Naturalcure() };
		public override Stats BaseStats => new Stats(51, 52, 90, 82, 110, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wrap(), new Moves.Growth() },
			[3] = new List<Move>() { new Moves.Vinewhip() },
			[6] = new List<Move>() { new Moves.Helpinghand() },
			[9] = new List<Move>() { new Moves.Drainingkiss() },
			[12] = new List<Move>() { new Moves.Flowershield() },
			[15] = new List<Move>() { new Moves.Magicalleaf() },
			[18] = new List<Move>() { new Moves.Synthesis() },
			[21] = new List<Move>() { new Moves.Leechseed() },
			[24] = new List<Move>() { new Moves.Grassknot() },
			[27] = new List<Move>() { new Moves.Sweetkiss() },
			[30] = new List<Move>() { new Moves.Floralhealing() },
			[33] = new List<Move>() { new Moves.Petalblizzard() },
			[36] = new List<Move>() { new Moves.Aromatherapy() },
			[39] = new List<Move>() { new Moves.Playrough() },
			[42] = new List<Move>() { new Moves.Sweetscent() },
			[45] = new List<Move>() { new Moves.Petaldance() },
			[48] = new List<Move>() { new Moves.Grassyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Playrough(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Leaftornado(), new Moves.Worryseed() };
		public override int Weight => 3;
		public override int ExpYield => 170;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}