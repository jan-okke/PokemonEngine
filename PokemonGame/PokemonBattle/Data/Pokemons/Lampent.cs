using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lampent : Pokemon
	{
		public override string Name => "Lampent";
		public override List<Ability> AvailableAbilities => new() {new Flashfire(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(60, 40, 60, 55, 95, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Smog(), new Ember(), new Minimize() },
			[12] = new List<Move>() { new Confuseray() },
			[16] = new List<Move>() { new Hex() },
			[20] = new List<Move>() { new Willowisp() },
			[24] = new List<Move>() { new Firespin() },
			[28] = new List<Move>() { new Nightshade() },
			[32] = new List<Move>() { new Curse() },
			[36] = new List<Move>() { new Shadowball() },
			[40] = new List<Move>() { new Inferno() },
			[46] = new List<Move>() { new Imprison() },
			[52] = new List<Move>() { new Painsplit() },
			[58] = new List<Move>() { new Overheat() },
			[64] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Heatwave(), new Hex(), new Hiddenpower(), new Imprison(), new Mysticalfire(), new Overheat(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Trick(), new Trickroom(), new Willowisp() };
		public override int Weight => 130;
		public override int ExpYield => 130;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}