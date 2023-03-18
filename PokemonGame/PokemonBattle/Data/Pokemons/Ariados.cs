using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ariados : Pokemon
	{
		public override string Name => "Ariados";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Insomnia() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(70, 90, 70, 40, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Swordsdance() },
			[1] = new List<Move>() { new Swordsdance(), new Focusenergy(), new Venomdrench(), new Fellstinger(), new Bugbite(), new Poisonsting(), new Stringshot(), new Absorb() },
			[5] = new List<Move>() { new Absorb() },
			[8] = new List<Move>() { new Infestation() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Nightshade() },
			[19] = new List<Move>() { new Shadowsneak() },
			[23] = new List<Move>() { new Furyswipes() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Leechlife() },
			[37] = new List<Move>() { new Agility() },
			[41] = new List<Move>() { new Pinmissile() },
			[46] = new List<Move>() { new Psychic() },
			[50] = new List<Move>() { new Poisonjab() },
			[55] = new List<Move>() { new Crosspoison() },
			[58] = new List<Move>() { new Stickyweb() },
			[63] = new List<Move>() { new Toxicthread() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bugbite(), new Bugbuzz(), new Confide(), new Dig(), new Doubleteam(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Leechlife(), new Poisonjab(), new Protect(), new Psychic(), new Rest(), new Return(), new Round(), new Signalbeam(), new Sleeptalk(), new Sludgebomb(), new Smartstrike(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thief(), new Throatchop(), new Venoshock(), new Xscissor() };
		public override int Weight => 335;
		public override int ExpYield => 140;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}