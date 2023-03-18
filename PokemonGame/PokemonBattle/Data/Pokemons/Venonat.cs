using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Venonat : Pokemon
	{
		public override string Name => "Venonat";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes(), new Tintedlens() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Runaway() };
		public override Stats BaseStats => new Stats(60, 55, 50, 45, 40, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Disable(), new Strugglebug() },
			[5] = new List<Move>() { new Supersonic() },
			[11] = new List<Move>() { new Confusion() },
			[13] = new List<Move>() { new Poisonpowder() },
			[17] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Stunspore() },
			[25] = new List<Move>() { new Megadrain() },
			[29] = new List<Move>() { new Sleeppowder() },
			[35] = new List<Move>() { new Leechlife() },
			[37] = new List<Move>() { new Zenheadbutt() },
			[41] = new List<Move>() { new Poisonfang() },
			[47] = new List<Move>() { new Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbite(), new Confide(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Hiddenpower(), new Infestation(), new Leechlife(), new Protect(), new Psychic(), new Rest(), new Return(), new Round(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Venoshock(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Batonpass(), new Bugbite(), new Morningsun(), new Ragepowder(), new Screech(), new Toxicspikes() };
		public override int Weight => 300;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}