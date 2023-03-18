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
		public override List<Ability> AvailableAbilities => new() {new Flowerveil(), new Triage() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Naturalcure() };
		public override Stats BaseStats => new Stats(51, 52, 90, 82, 110, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Growth() },
			[3] = new List<Move>() { new Vinewhip() },
			[6] = new List<Move>() { new Helpinghand() },
			[9] = new List<Move>() { new Drainingkiss() },
			[12] = new List<Move>() { new Flowershield() },
			[15] = new List<Move>() { new Magicalleaf() },
			[18] = new List<Move>() { new Synthesis() },
			[21] = new List<Move>() { new Leechseed() },
			[24] = new List<Move>() { new Grassknot() },
			[27] = new List<Move>() { new Sweetkiss() },
			[30] = new List<Move>() { new Floralhealing() },
			[33] = new List<Move>() { new Petalblizzard() },
			[36] = new List<Move>() { new Aromatherapy() },
			[39] = new List<Move>() { new Playrough() },
			[42] = new List<Move>() { new Sweetscent() },
			[45] = new List<Move>() { new Petaldance() },
			[48] = new List<Move>() { new Grassyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Amnesia(), new Attract(), new Bulletseed(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Encore(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Magicalleaf(), new Playrough(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Trick(), new Trickroom(), new Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Leaftornado(), new Worryseed() };
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