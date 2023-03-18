using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Oranguru : Pokemon
	{
		public override string Name => "Oranguru";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Telepathy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Symbiosis() };
		public override Stats BaseStats => new Stats(90, 60, 80, 90, 110, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Taunt() },
			[5] = new List<Move>() { new Afteryou() },
			[10] = new List<Move>() { new Calmmind() },
			[15] = new List<Move>() { new Storedpower() },
			[20] = new List<Move>() { new Psychup() },
			[25] = new List<Move>() { new Quash() },
			[30] = new List<Move>() { new Nastyplot() },
			[35] = new List<Move>() { new Zenheadbutt() },
			[40] = new List<Move>() { new Trickroom() },
			[45] = new List<Move>() { new Psychic() },
			[50] = new List<Move>() { new Instruct() },
			[55] = new List<Move>() { new Foulplay() },
			[60] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Calmmind(), new Earthquake(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Fling(), new Focusblast(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Round(), new Safeguard(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Taunt(), new Terrainpulse(), new Thunder(), new Thunderbolt(), new Trick(), new Trickroom(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Dreameater(), new Extrasensory(), new Lastresort(), new Yawn() };
		public override int Weight => 760;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
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