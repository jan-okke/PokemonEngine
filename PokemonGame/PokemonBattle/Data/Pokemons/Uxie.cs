using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Uxie : Pokemon
	{
		public override string Name => "Uxie";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(75, 75, 130, 75, 130, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Rest() },
			[7] = new List<Move>() { new Swift() },
			[14] = new List<Move>() { new Endure() },
			[21] = new List<Move>() { new Psybeam() },
			[28] = new List<Move>() { new Imprison() },
			[35] = new List<Move>() { new Extrasensory() },
			[42] = new List<Move>() { new Amnesia() },
			[49] = new List<Move>() { new Psychic() },
			[56] = new List<Move>() { new Yawn() },
			[63] = new List<Move>() { new Futuresight() },
			[70] = new List<Move>() { new Flail() },
			[77] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Amnesia(), new Batonpass(), new Calmmind(), new Chargebeam(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Foulplay(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Imprison(), new Irontail(), new Lightscreen(), new Magicroom(), new Metronome(), new Nastyplot(), new Playrough(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Uturn(), new Waterpulse(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 3;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}